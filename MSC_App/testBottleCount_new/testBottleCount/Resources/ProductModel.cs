using System;
using System.Collections.Generic;
using System.Text;

namespace BottlePickModuleForWindows.Resources
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public int Bin { get; set; }
        public string PickToLightAddress { get; set; }
        public string PickToLightControllerIP { get; set; }
        public string BoxTransID { get; set; }

        /// <summary>
        /// 0 not pick 1 out of stock,2 picked
        /// </summary>
        public int PickStatus { get; set; }

        public int ActualPickCount { get; set; }
    }
}
