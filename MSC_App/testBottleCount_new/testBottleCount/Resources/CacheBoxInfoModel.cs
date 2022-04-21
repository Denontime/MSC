using System;
using System.Collections.Generic;
using System.Drawing;

namespace BottlePickModuleForWindows.Resources
{
    public class CacheBoxInfoModel
    {
        public string DivertModule { get; set; }
        public string PhotoKey { get; set; }
        public Bitmap ReceivedImage { get; set; }
        public string ImageId { get; set; }
        public string BarCode { get; set; }
        public QAStatus qaStatus { get; set; }
        public DateTime ScannerTimeScanned { get; set; }
        public DateTime CameraTimePhotoed { get; set; }
        //public Dictionary<string, Product> needPickProduct { get; set; }
        public List<ProductModel> needPickProduct { get; set; }
        public ReleaseStatus boxStatus { get; set; }
        /// <summary>
        /// According to the barcode message to determine the number of bottles in the box.
        /// </summary>
        /// <returns>Bottle count.</returns>
        public int BottleCount { get; set; }

    }

    public enum QAStatus
    {
        QAFailed = 0,
        QAPass = 1
    }

    public enum ReleaseStatus
    {
        NotRelease = 0,
        Release = 1
    }
}