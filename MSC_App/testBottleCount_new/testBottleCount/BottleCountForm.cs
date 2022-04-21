using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BottlePickModuleForWindows.Controller;
using BottlePickModuleForWindows.Resources;
using BottlePickModuleForWindows.Service;
using BottlePickModuleForWindows.Utility;
using WCS.VisionBox;
using GrpcService = WCS.VisionBox.GrpcService;

namespace testBottleCount
{
    public partial class BottleCountMain : Form
    {
        public static BottleCountMain mainForm =null;
        string statusInfo = "CameraCount:{0},  ScannerCount:{1},  MQTTStauts:{2}";
        VisionBoxController myVisionBoxController = null;

        public int cameraCount = 0;
        public int scannerCount = 0;
        public bool mqttStatus = false;
        ProductDisplay pd = null;

        public BottleCountMain()
        {
            InitializeComponent();
            pd = new ProductDisplay();
            pd.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(pd);
            //GlobalSetting.GlobaModuleModel = HttpService.RequestModuleInfo(GlobalSetting.ModuleID);
            GlobalSetting.GlobaModuleModel = new ModuleModel();
            mainForm = this;
        }

        private void BottleCountMain_Load(object sender, EventArgs e)
        {
            // 考虑异步等待问题
            myVisionBoxController = new VisionBoxController();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.myVisionBoxController.ProcessScannerReciveData(1, "123456789", "20201214001", DateTime.Now);

            string absolutPath = Directory.GetCurrentDirectory();
            UpdataImage(absolutPath + "\\S_12204606230464820109.jpg");

            this.UpdataQAStatus();
        }

        private void btnQA_Click(object sender, EventArgs e)
        {
            myVisionBoxController.trigerCamera("");
            //提示 正在 qa

        }


        private void btnReQA_Click(object sender, EventArgs e)
        {
            myVisionBoxController.trigerCamera("");
        }

        private void Released_Click(object sender, EventArgs e)
        {
            updateProductList(null);
        }
   
        public void UpdateDeviceStatusInfo()
        {
            ToolStripLabel tmpLabel = this.DeviceStatus.Items[0] as ToolStripLabel;
            tmpLabel.Text = string.Format(statusInfo, cameraCount, scannerCount, mqttStatus);
        }

    
        public void UpdateBarcode(string barcode)
        {
            if (this.lblBarcode.InvokeRequired)
            {
                while (!this.lblBarcode.IsHandleCreated)
                {
                    if (this.lblBarcode.Disposing || this.lblBarcode.IsDisposed)
                        return;
                }
                this.lblBarcode.Invoke(new Action<string>((msg)=> { this.lblBarcode.Text = msg; }),barcode);
            }
            else
            {
                this.lblBarcode.Text = barcode;
            }
        }

        public void UpdateSectionPickCount(int pickCount)
        {
            if (this.lblSectionPickCount.InvokeRequired)
            {
                while (!this.lblSectionPickCount.IsHandleCreated)
                {
                    if (this.lblSectionPickCount.Disposing || this.lblSectionPickCount.IsDisposed)
                        return;
                }
                this.lblSectionPickCount.Invoke(new Action<string>((msg) => { this.lblSectionPickCount.Text = msg; }), pickCount.ToString());
            }
            else
            {
                this.lblSectionPickCount.Text = pickCount.ToString();
            }
        }

        public void UpdataImage(string imageSrc)
        {
            if (this.PBImage.InvokeRequired)
            {
                while (!this.PBImage.IsHandleCreated)
                {
                    if (this.PBImage.Disposing || this.PBImage.IsDisposed)
                        return;
                }
                this.PBImage.Invoke(new Action<string>((image) => { this.PBImage.Image = Image.FromFile(image); }), imageSrc);
            }
            else
            {
                this.PBImage.Image = Image.FromFile(imageSrc);
            }
        }

        public void UpdataQAStatus()
        {
            if (this.lblTotalCount.InvokeRequired)
            {
                while (!this.lblTotalCount.IsHandleCreated)
                {
                    if (this.lblTotalCount.Disposing || this.lblTotalCount.IsDisposed)
                        return;
                }
                this.lblTotalCount.Invoke(new Action<string,string,string,string>((msg1,msg2,msg3,msg4) => {
                    this.lblTotalCount.Text = "15";
                    this.lblQaStatus.Text = "QAPass";
                    this.lblCurrentSectionPickCount.Text = "15";
                    this.lblLastTotalCount.Text = "0";
                }),"0","0","0","0");
            }
            else
            {
                this.lblTotalCount.Text = "15";
                this.lblQaStatus.Text = "QAPass";
                this.lblCurrentSectionPickCount.Text = "15";
                this.lblLastTotalCount.Text = "0";
            }
        }

        public void updateProductList(List<ProductModel> products)
        {
            this.pd.UpdateProduct(products);
        }


    }
}
