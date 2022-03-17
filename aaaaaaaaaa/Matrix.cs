using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaaa
{
    internal class Matrix : Filter
    {
        protected float[,] kernel = null;
        protected Matrix() { }
        public Matrix(float[,] kernel)
        {
            this.kernel = kernel;
        }
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0)/2;
            int radiusY = kernel.GetLength(1)/2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clump(x + k, 0, sourceImage.Width - 1);
                    int idY = Clump(y + l, 0, sourceImage.Height - 1);
                    Color neibourColor = sourceImage.GetPixel(idX, idY);
                    resultR += neibourColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neibourColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neibourColor.B * kernel[k + radiusX, l + radiusY];
                    
                }
            return Color.FromArgb(Clump((int)resultR,0,255), Clump((int)resultG,0,255), Clump((int)resultB,0,255));
        }
    }
}

