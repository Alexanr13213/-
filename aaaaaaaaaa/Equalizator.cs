using System.Drawing;
using System;

namespace aaaaaaaaaa
{
    internal class Equalizator
    {
        public Color Equalization(Bitmap sourceimage)
        {
            Rectangle rect = new Rectangle(0, 0, sourceimage.Width, sourceimage.Height);
            System.Drawing.Imaging.BitmapData bmpData = sourceimage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, sourceimage.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int bytes = bmpData.Stride * sourceimage.Height;
            byte[] grayValues = new byte[bytes];
            int[] R = new int[256];
            byte[] N = new byte[256];
            byte[] left = new byte[256];
            byte[] right = new byte[256];
            System.Runtime.InteropServices.Marshal.Copy(ptr, grayValues, 0, bytes);

            for (int i = 0; i < grayValues.Length; i++)
            {
                ++R[grayValues[i]];
            }

            byte z = 0;
            int Hint = 0;
            int Havg = grayValues.Length / R.Length;
            for (int i = 0; i < N.Length - 1; i++)
            {
                N[i] = 0;
            }
            for (int j = 0; j < R.Length; j++)
            {
                left[j] = z;
                Hint += R[j];
                while (Hint > Havg)
                {
                    Hint -= Havg;
                    z++;
                }
                right[j] = z;
                N[j] = (byte)((left[j] + right[j]) / 2);
            }
            for (int i = 0; i < grayValues.Length; i++)
            {
                if (left[grayValues[i]] == right[grayValues[i]]) grayValues[i] = (byte)left[grayValues[i]];
                else grayValues[i] = (byte)N[grayValues[i]];
            }

            System.Runtime.InteropServices.Marshal.Copy(grayValues, 0, ptr, bytes);
            sourceimage.UnlockBits(bmpData);
            return sourceimage;
        }
    }
}
