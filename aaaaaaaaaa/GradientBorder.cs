using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace aaaaaaaaaa
{

    public partial class GradientBorder
    {
        public void EdgeDetection(Bitmap sourceImage,float threshold)
        {
            Bitmap bSrc = (Bitmap)sourceImage.Clone();

            BitmapData bmData = sourceImage.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;

            unsafe
            {
                byte* p = (byte*)(void*)bmData.Scan0;
                byte* pSrc = (byte*)(void*)bmSrc.Scan0;

                int nOffset = stride - sourceImage.Width * 3;
                int nWidth = sourceImage.Width - 1;
                int nHeight = sourceImage.Height - 1;

                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        var p0 = ToGray(pSrc);
                        var p1 = ToGray(pSrc + 3);
                        var p2 = ToGray(pSrc + 3 + stride);

                        if (Math.Abs(p1 - p2) + Math.Abs(p1 - p0) > threshold)
                            p[0] = p[1] = p[2] = 255;
                        else
                            p[0] = p[1] = p[2] = 0;

                        p += 3;
                        pSrc += 3;
                    }
                    p += nOffset;
                    pSrc += nOffset;
                }
            }

            sourceImage.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);
        }

        static unsafe float ToGray(byte* bgr)
        {
            return bgr[2] * 0.3f + bgr[1] * 0.59f + bgr[0] * 0.11f;
        }
    }
}