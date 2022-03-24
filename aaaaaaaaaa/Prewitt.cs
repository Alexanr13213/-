using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace aaaaaaaaaa
{
    class Prewit : MatrixFilter
    {
        protected float[,] kernelX;
        protected float[,] kernelY;

        public Prewit()
        {
            kernelX = new float[,] {    { -1, 0, 1 },
                                        { -1, 0, 1 },
                                        { -1, 0, 1 } };
            kernelY = new float[,] {    { -1, -1, -1 },
                                        { 0, 0, 0 },
                                        { 1, 1, 1 } };
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            kernel = kernelX;
            Color valueX = base.CalculateNewPixelColor(sourceImage, x, y);
            kernel = kernelY;
            Color valueY = base.CalculateNewPixelColor(sourceImage, x, y);

            return Color.FromArgb(
                    Clump((int)Math.Sqrt(valueX.R * valueX.R + valueY.R * valueY.R), 0, 255),
                    Clump((int)Math.Sqrt(valueX.G * valueX.G + valueY.G * valueY.G), 0, 255),
                    Clump((int)Math.Sqrt(valueX.B * valueX.B + valueY.B * valueY.B), 0, 255)
                    );

        }
    }
}
