using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCS.VisionBox;
using BottlePickModuleForWindows.Service;
using System.Drawing;
using System.IO;
using BottlePickModuleForWindows.Utility;
using BottlePickModuleForWindows.Resources;
using GrpcService = BottlePickModuleForWindows.Service.GrpcService;

namespace BottlePickModuleForWindows.Controller
{
    class VisionBoxController
    {
        private List<CameraSettingsModel> cameraModelSettingList = null;
        private VisionBox myVisionBox = null;

        MqttService mqttClient = null;


        public VisionBoxController()
        {

            cameraModelSettingList = new List<CameraSettingsModel>();
            mqttClient = MqttService.getMqttInstance();
            //启动相机后，如果程序报错需及时释放相机连接状态
            try
            {
                LoadVisionBox();
            }
            catch (Exception)
            {
                myVisionBox.StopCamera();
                throw;
            }

        }

        private void LoadVisionBox()
        {

            // 读取XML 
            CameraSettingsModel cameraSettings = new CameraSettingsModel();
            cameraSettings.ID = 1;
            cameraSettings.m_ipAddress = "192.168.10.12";
            cameraSettings.m_isRiseEdge = true;
            cameraSettings.m_exposureTime = (uint)45000;
            cameraSettings.m_triggerDelay = (uint)1000;
            cameraSettings.m_timeDelay = (uint)1000;
            cameraSettings.m_whiteBalanceRed = (uint)197;
            cameraSettings.m_whiteBalanceGreen = (uint)96;
            cameraSettings.m_whiteBalanceBlue = (uint)102;
            cameraSettings.m_isSoftwareTrigger = true;
            cameraSettings.m_name = "top";
            cameraModelSettingList.Add(cameraSettings);

            myVisionBox = new VisionBox(divertModuleID: 1,
                                        scannerServerPort: "40010",
                                        cameraModelList: cameraModelSettingList);

            myVisionBox.OnVisionBoxScannerClientConnect += ProcessScannerConnect;
            myVisionBox.OnVisionBoxScannerClientDisConnect += ProcessScannerDisConnect;
            myVisionBox.OnVisionBoxScannerDataProcess += ProcessScannerReciveData;

            myVisionBox.OnVisionBoxCameraConnect += ProcessCameraConnect;
            myVisionBox.OnVisionBoxCameraDisConnect += ProcessCameraDisConnect;
            myVisionBox.OnVisionBoxCameraDataProcess += ProcessCameraReciveData;

            myVisionBox.OnVisionBoxError += MyVisionBox_OnVisionBoxError;

            myVisionBox.InitializeScanner();
            myVisionBox.StartScanner();
            myVisionBox.InitializeCamera();
            myVisionBox.StartCamera();
        }
        private void MyVisionBox_OnVisionBoxError(VisionBoxException exception)
        {

        }

        public void trigerCamera(string ip)
        {
            myVisionBox.trigerCameraBySoft("");
        }
        
        internal void ProcessScannerReciveData(int divertModuleID, string barcode, string BoxKey, DateTime scanTime)
        {
            //根据barcode获取产品列表

            //1 请求api 获取数据 
            // 修改为 委托事件
            testBottleCount.BottleCountMain.mainForm.UpdateBarcode(barcode);
            ProductModel product1 = new ProductModel()
            {
                ProductID = 38516,
                ProductName = "ol' glory non-priced sugar free 24/16 cn",
                Count = 5,
                Bin = 1,
                PickToLightAddress = "00-0E-1A",
                PickToLightControllerIP = "192.168.10.134",
                BoxTransID = "123"

            };
            ProductModel product2 = new ProductModel()
            {
                ProductID = 40604,
                ProductName = "arizona mucho mango 24/23oz cn",
                Count = 5,
                Bin = 1,
                PickToLightAddress = "00-0E-09",// 灯地址
                PickToLightControllerIP = "192.168.10.134",//网关
                BoxTransID = "122",

            };
            //2 亮灯



            // 修改为 委托事件
            testBottleCount.BottleCountMain.mainForm.UpdateSectionPickCount(10);
            List<ProductModel> tmpModelList = new List<ProductModel> { product1, product2 };
            CacheBoxInfoModel CacheInfo = new CacheBoxInfoModel();
            CacheInfo.needPickProduct = tmpModelList;
            //更新CacheBoxInfoModel 的状态 BoxKey 即为photokey

            GlobalSetting.GlobaModuleModel.ModuleCacheBoxs.Add(CacheInfo);
            //亮灯
            //myPtlCpntroller.ProcessSend2PTLData(CacheInfo);

        }
        public void ProcessCameraReciveData(string ip, string imageid, Bitmap receivedImage)
        {
            CacheBoxInfoModel currentCacheBox = GlobalSetting.GlobaModuleModel.ModuleCacheBoxs.FirstOrDefault<CacheBoxInfoModel>(item => item.boxStatus == ReleaseStatus.NotRelease);
            //判断currentCacheBox 是否为空，如果为空报错，并进行界面提示

            string imgBase64 = ImageHelper.ConvertImageToBase64(receivedImage);
            var dectionResult = GrpcService.InferenceObjectDetection(imgBase64, currentCacheBox.PhotoKey);
            int detectCount = dectionResult.Result.ObjScore.Count;
            Console.WriteLine($"DetectionResult:{detectCount}");
            //bool QAResult = detectCount.Equals(8);
            bool QAResult = true;  //需要和currentCacheBox中的总数量进行对比
            if (QAResult)
            {
                mqttClient.Publish("photo", "QA success");
                //放行。 目前可以使用手动更新  发送命令（mqtt）给IOT 网关
                //更新界面
                //更新数据库状态
                //报错图像数据
            }
            else
            {
                mqttClient.Publish("photo", "QA failed");
                //更新界面
            }



            //1.获取图片数据进行base64编码，并请求grpc server获得检测结果。
            //2.比对订单信息和检测结果
            //3.upload QA数据至相应的数据表（http请求）
            //3.根据比对结果，向客户端发送QA结果消息（mqtt），
            //4.如果QA成功：调用IotHelp执行放行动作，

        }



        internal void ProcessCameraConnect(bool isConn, string info)
        {
            // 修改为 委托事件
            if (testBottleCount.BottleCountMain.mainForm.cameraCount > 0)
            {
                testBottleCount.BottleCountMain.mainForm.cameraCount -= 1;
            }
            testBottleCount.BottleCountMain.mainForm.UpdateDeviceStatusInfo();
        }

        internal void ProcessCameraDisConnect(bool isDisconn, string info)
        {
            // 修改为 委托事件
            if (testBottleCount.BottleCountMain.mainForm.cameraCount > 0)
            {
                testBottleCount.BottleCountMain.mainForm.cameraCount -= 1;
            }
            testBottleCount.BottleCountMain.mainForm.UpdateDeviceStatusInfo();

        }



        internal void ProcessScannerConnect(string IPAddress, string Port)
        {
            // 修改为 委托事件
            testBottleCount.BottleCountMain.mainForm.scannerCount += 1;
            testBottleCount.BottleCountMain.mainForm.UpdateDeviceStatusInfo();
        }

        internal void ProcessScannerDisConnect(string IPAddress, string Port)
        {
            // 修改为 委托事件
            if (testBottleCount.BottleCountMain.mainForm.scannerCount > 0)
            {
                testBottleCount.BottleCountMain.mainForm.scannerCount -= 1;
            }
            testBottleCount.BottleCountMain.mainForm.UpdateDeviceStatusInfo();
        }







    }








}
