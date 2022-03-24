using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace aaaaaaaaaa
{
    class Wave30 : Filter
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int nX = (int)(x + 20 * Math.Sin(2 * Math.PI * y / 30));
            int nY = (int)y;

            if (nX >= sourceImage.Width || nX < 0 || nY >= sourceImage.Height || nY < 0)
            {
                return Color.Black;
            }

            return sourceImage.GetPixel(nX, nY);
        }
    }
}
