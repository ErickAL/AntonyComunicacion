using System.Drawing;

namespace AntonyCelulares.Helpers
{
    public  interface IImageHelper
    {
        public byte[] ImageToByteArray(Image img);
        public Image ByteArrayToImage(byte[] byteArrayIn);
        public  byte[] ImageToByteConverter(Image inImg);
    }
}