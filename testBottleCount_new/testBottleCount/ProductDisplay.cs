using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BottlePickModuleForWindows.Resources;

namespace testBottleCount
{
    public partial class ProductDisplay : UserControl
    {
        Dictionary<int, string> mapStatus = new Dictionary<int, string>();
        public ProductDisplay()
        {
            //0 not pick 1 out of stock,2 pick
            InitializeComponent();
            mapStatus.Add(0, "not pick");
            mapStatus.Add(1, "out of stock");
            mapStatus.Add(2, "picked");
        }

        public void UpdateProduct(List<ProductModel> productList)
        {
            this.panel4.Controls.Clear();
            this.panel5.Controls.Clear();
            int tagNumber = 1;
            if (productList != null)
            {
                foreach (ProductModel item in productList)
                {
                    Label tmpLableProduct = new Label();
                    tmpLableProduct.Text = item.ProductName;
                    tmpLableProduct.Top = (tagNumber - 1) * 20 + 20;
                    tmpLableProduct.AutoSize = true;


                    Label tmpLableStatus = new Label();
                    tmpLableStatus.Text = mapStatus[item.PickStatus];
                    tmpLableStatus.Top = (tagNumber - 1) * 20 + 20;
                    tmpLableStatus.AutoSize = true;

                    tmpLableProduct.Tag = tagNumber;
                    tmpLableStatus.Tag = tagNumber;
                    this.panel4.Controls.Add(tmpLableProduct);
                    this.panel5.Controls.Add(tmpLableStatus);
                    tagNumber++;
                }
            }
            
        }

        //internal void UpdateProduct(List<ProductModel> products)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
