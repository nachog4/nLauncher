using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nLauncher
{
    public static class Tools
    {
        public static Byte[] GetByteFromUrl (string url) {

            Byte[] result = null;

            if (!String.IsNullOrEmpty(url))
            {
                var webClient = new WebClient();
                try
                {
                    result = webClient.DownloadData(url);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return result;

        }

        public static Image GetImageFromByte (Byte[] byteImage)
        {
            Image result = null;

            using (var ms = new MemoryStream(byteImage))
            {
                result = Image.FromStream(ms);
            }

            return result;
        }

        public static Image GetImageFromUrl (string url)
        {
            Image result = null;

            if (!String.IsNullOrEmpty(url))
            {
                var webClient = new WebClient();
                Byte[] byteImage = webClient.DownloadData(url);

                using (var ms = new MemoryStream(byteImage))
                {
                    result = Image.FromStream(ms);
                }

            }
            return result;

        }

        public static Byte[] GetByteFromImage (Image image)
        {
            Byte[] result = null;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                result = ms.ToArray();
            }

            return result;
        }

    }
}
