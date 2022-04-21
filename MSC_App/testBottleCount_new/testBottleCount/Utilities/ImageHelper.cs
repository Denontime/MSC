using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace BottlePickModuleForWindows.Utility
{
    public class ImageHelper
    {
        public static string ConvertImageToBase64(string imgPath)
        {
            string base64 = null;
            using (Bitmap bm = new Bitmap(imgPath))
            {
                using (System.IO.MemoryStream ms = new MemoryStream())
                {
                    bm.Save(ms, ImageFormat.Jpeg);
                    base64 = Convert.ToBase64String(ms.ToArray());
                }
            }
            return base64;
        }
        public static string ConvertImageToBase64(Stream ImageStream)
        {
            string base64 = null;
            using (Bitmap bm = new Bitmap(ImageStream))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bm.Save(ms, ImageFormat.Jpeg);
                    base64 = Convert.ToBase64String(ms.ToArray());
                }
            }
            return base64;
        }
        public static string ConvertImageToBase64(Bitmap Image)
        {
            string base64 = null;
            using (MemoryStream ms = new MemoryStream())
            {
                Image.Save(ms, ImageFormat.Jpeg);
                base64 = Convert.ToBase64String(ms.ToArray());
            }
            return base64;
        }
    }
}
