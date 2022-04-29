using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace GameStore
{
    class DataTransform
    {
        public static byte[] JPGTOByte(BitmapImage image)
        {
            MemoryStream memory = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            encoder.Save(memory);
            return memory.ToArray();
        }

        public static BitmapImage ByteToImage(byte[] mas)
        {
            using (var ms = new System.IO.MemoryStream(mas))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }
    }
}
