using System;
using System.Collections.Generic;
using System.Text;
using WCS.VisionBox;

namespace BottlePickModuleForWindows.Resources
{
    public class ModuleModel
    {

        private List<CacheBoxInfoModel> _moduleCacheBoxs;
        public List<CacheBoxInfoModel> ModuleCacheBoxs { 
            get 
            {
                if (_moduleCacheBoxs == null) {
                    _moduleCacheBoxs = new List<CacheBoxInfoModel>();
                }
                return _moduleCacheBoxs;
            }
            set 
            {
                if (value == null)
                {
                    _moduleCacheBoxs = value;
                }
            }
        }

        public int BottlePickModuleID { get; set; }
        public int BinZoneID { get; set; }
        private int status { get; set; }
        public string ModuleName { get; set; }
        public string IPAddress { get; set; }
        public int PTLPort { get; set; }
        public string SoftwareVersion { get; set; }
        public string DeviceSerialNumber { get; set; }
        public CameraSettingsModel wcsCameraSettingsModel { get; set; }
        //public ScannerSettingsModel wcsScannerSettingsModel { get; set; }
        public string GrpcServerIP { get; set; }
        public int GrpcServerPort { get; set; }
    }
}
