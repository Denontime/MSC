using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottlePickModuleForWindows.Enmu;
using BottlePickModuleForWindows.Resources;
using BottlePickModuleForWindows.Utility;
using WCS.PickToLight;

namespace BottlePickModuleForWindows.Controller
{
    class PtlController
    {
        public PickToLight pickToLight;


        public PtlController()
        {

            //    public event StatusChangedHandler StatusChangedEvent;
            //public event PushLightInBindingStatusHandler PushLightInBindingEvent;
            //public event PushLEDLightInPickingStatusHandler PushLEDLightInPickingEvent;
            //public event PushLCDLightInPickingStatusHandler PushLCDLightInPickingEvent;
            pickToLight = new PickToLight(null, 40101);
            pickToLight.PushLEDLightInPickingEvent += ProcessPTLPickedData;
            pickToLight.StatusChangedEvent += PickToLight_StatusChangedEvent;
            pickToLight.PushLightInBindingEvent += PickToLight_PushLightInBindingEvent;
            //pickToLight.PushLCDLightInPickingEvent += PickToLight_PushLCDLightInPickingEvent;
            pickToLight.Config();

        }

        //private void PickToLight_PushLCDLightInPickingEvent(object obj, List<LCDPickedResult> pickedResults)
        //{
            
        //}

        private void PickToLight_PushLightInBindingEvent(object obj, string controllerIp, string lightAddress)
        {
            
        }

        private void PickToLight_StatusChangedEvent(object obj, PickToLightStatus state)
        {
            
        }

        //public void ProcessPTLData(byte[] value, int len, string ipAddress, string port, PTLModel ptlModel)
        //{


        //}

        //按灯 之后 返回的数据
        public void ProcessPTLPickedData(object obj, Dictionary<string, PickToLightPushType> lightAddressPushTypeDic)
        {
            CacheBoxInfoModel tmpCacheBoxInfo = GlobalSetting.GlobaModuleModel.ModuleCacheBoxs[0];
            List<ProductModel> tmpProductList = tmpCacheBoxInfo.needPickProduct;
            foreach (ProductModel tmpProduct in tmpProductList)
            {
                //根据亮灯返回的状态，进行产品pick数量的更新
                //if (lightAddressPushTypeDic[tmpProduct.PickToLightAddress].Equals(PickToLightPushType.NoInventory))
                //{
                //    tmpProduct.PickStatus = (int)PickToLightPushType.NoInventory;
                //}
                //else
                //{
                //    tmpProduct.PickStatus = (int)PickToLightPushType.Picked;
                //}
            }
        }

        //亮灯
        public void ProcessSend2PTLData(CacheBoxInfoModel cacheBoxInfo)
        {
            //pickToLight.LightUpLED
        }
    }
}
