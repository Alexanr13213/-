using System;
using System.Collections.Generic;
using System.Drawing;

namespace aaaaaaaaaa
{
    class Erozia
    {
        public Bitmap processImage(Bitmap sourceImage)
        {

            List<Color> colorlistErosion = new List<Color>();
            int colorValueR, colorValueG, colorValueB;
            int tel = 0;

            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color col = sourceImage.GetPixel(x, y);
                    colorValueR = col.R; colorValueG = col.G; colorValueB = col.B;
                    for (int a = -1; a < 2; a++)
                    {
                        for (int b = -1; b < 2; b++)
                        {
                            try
                            {
                                Color col2 = sourceImage.GetPixel(x + a, y + b);
                                colorValueR = Math.Min(colorValueR, col2.R);
                                colorValueG = Math.Min(colorValueG, col2.G);
                                colorValueB = Math.Min(colorValueB, col2.B);
                            }
                            catch
                            {
                            }
                        }
                    }
                    colorlistErosion.Add(Color.FromArgb(0 + colorValueR, 0 + colorValueG, 0 + colorValueB));
                }
            }
            for (int een = 0; een < sourceImage.Height; een++)
                for (int twee = 0; twee < sourceImage.Width; twee++)
                {
                    sourceImage.SetPixel(twee, een, colorlistErosion[tel]);
                    tel++;
                }
            return sourceImage;
        }
        
    }
}
    
        
