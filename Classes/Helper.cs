using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace SmartPOS.Classes
{
    public class Helper
    {
        public static Byte[] ImageToByte(Image image)
        {
            Byte[] bResult = null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                bResult = ms.ToArray();
            }

            return bResult;
        }
        public static Image ByteToImage(object bObj)
        {
            Byte[] myImg = (Byte[])bObj;
            Image image = null;
            using (MemoryStream ms = new MemoryStream(myImg, 0, myImg.Length))
            {
                ms.Write(myImg, 0, myImg.Length);
                image = Image.FromStream(ms, true);
            }
            return image;
        }
    }
}
