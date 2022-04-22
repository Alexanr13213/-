using System.Drawing;

namespace aaaaaaaaaa
{
    class MathMorf
    {
        public Bitmap processImage(Bitmap sourceImage)
        {
            int W = sourceImage.Width;
            int H = sourceImage.Height;
            Bitmap resultImage = new Bitmap(W, H);

            // УСТАНОВИТЬ РАЗМЕРЫ СТРУКТУРНОГО ЭЛЕМЕНТА
            int MW = 3;
            int MH = 5;
            int[,] mask = new int[MW, MH];

            mask[0, 0] = 0;
            mask[0, 1] = 1;
            mask[0, 2] = 0;

            mask[1, 0] = 1;
            mask[1, 1] = 1;
            mask[1, 2] = 1;

            mask[2, 0] = 0;
            mask[2, 1] = 1;
            mask[2, 2] = 0;


            for (int y = MH / 2; y < H - MH / 2; y++)
            {
                for (int x = MW / 2; x < W - MW / 2; x++)
                {
                    int max = 0;
                    for (int j = -MH / 2; j <= MH / 2; j++)
                    {
                        for (int i = -MW / 2; i <= MW / 2; i++)
                        {
                            if ((mask[i + MW / 2, j + MH / 2] == 1) && (sourceImage.GetPixel(x + i, y + j).R > max))
                            {
                                max = sourceImage.GetPixel(x + i, y + j).R;
                            }
                        }
                        resultImage.SetPixel(x, y, Color.FromArgb(255, max, max, max));
                    }
                }
            }
            return resultImage;
        }
    }
}
