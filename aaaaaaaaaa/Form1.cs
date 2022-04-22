using System;
using System.Drawing;
using System.Windows.Forms;

namespace aaaaaaaaaa
{
	public partial class Form1 : Form
	{
		Bitmap image;
		int[] array = new int[1000];
		double[] charr = new double[1000];
		public Form1()
		{
			InitializeComponent();
		}

		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "All files (*.*) | *.*";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				image = new Bitmap(dialog.FileName);
				pictureBox1.Image= image;
				pictureBox1.Refresh();
			}
		}

		private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Invert invert = new Invert();
			Bitmap resultImage = invert.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();
		}

		private void конвертерRGBLabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FromRGBtoLab convert = new FromRGBtoLab();
			Bitmap resultImage = convert.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();
		}

		private void волна30ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Wave30 wave = new Wave30();
			Bitmap resultImage = wave.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();
		}

		private void волна60ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Wave60 Wave = new Wave60();
			Bitmap resultImage = Wave.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();

		}

		private void превитToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Prewit previt = new Prewit();
			Bitmap resultImage = previt.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();

		}

        private void гауссToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Gauss gauss = new Gauss();
			Bitmap resultImage = gauss.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();
		}

        private void усреднениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Blur blur = new Blur();
			Bitmap resultImage = blur.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();
		}

        private void эквализацияГистограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
				Image resultImage = CalculateBarChart(image);
				pictureBox2.Image = resultImage;
				equalizing(image);
				
				pictureBox1.Image = (Bitmap)image;
				Bitmap copy = new Bitmap(image);
				copy = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);
		}

		

		public Bitmap equalizing(Bitmap image)
		{
			//Random rand = new Random();
			Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
			System.Drawing.Imaging.BitmapData bmpData = image.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, image.PixelFormat);
			IntPtr ptr = bmpData.Scan0;
			int bytes = bmpData.Stride * image.Height;
			byte[] grayValues = new byte[bytes];
			int[] R = new int[256];
			byte[] N = new byte[256];
			byte[] left = new byte[256];
			byte[] right = new byte[256];
			System.Runtime.InteropServices.Marshal.Copy(ptr, grayValues, 0, bytes);
			for (int i = 0; i < grayValues.Length; i++) ++R[grayValues[i]];
			int z = 0;
			int Hint = 0;
			int Havg = grayValues.Length / R.Length;
			for (int i = 0; i < N.Length - 1; i++)
			{

				N[i] = 0;
				


			}
			for (int j = 0; j < R.Length; j++)
			{
				if (z > 255) left[j] = 255;
				else left[j] = (byte)z;
				Hint += R[j];
				while (Hint > Havg)
				{
					Hint -= Havg;
					z++;
					


				}
				if (z > 255) right[j] = 255;
				else right[j] = (byte)z;

				N[j] = (byte)((left[j] + right[j]) / 2);
			}
			for (int i = 0; i < grayValues.Length; i++)
			{
				if (left[grayValues[i]] == right[grayValues[i]]) { grayValues[i] = left[grayValues[i]]; }
				else grayValues[i] = N[grayValues[i]];
			}

			System.Runtime.InteropServices.Marshal.Copy(grayValues, 0, ptr, bytes);
			image.UnlockBits(bmpData);


			return image;
		}

		public Image CalculateBarChart(Image image)
		{
			Bitmap barChart = null;
			if (image != null)
			{
				// определяем размеры гистограммы. В идеале, ширина должны быть кратна 768 - 
				// по пикселю на каждый столбик каждого из каналов
				int width = 400, height = 100;
				// получаем битмап из изображения
				Bitmap bmp = new Bitmap(image);
				// создаем саму гистограмму
				barChart = new Bitmap(width, height);
				// создаем массивы, в котором будут содержаться количества повторений для каждого из значений каналов.
				// индекс соответствует значению канала
				int[] R = new int[256];
				int[] G = new int[256];
				int[] B = new int[256];
				int i, j;
				Color color;
				// собираем статистику для изображения
				for (i = 0; i < bmp.Width; ++i)
					for (j = 0; j < bmp.Height; ++j)
					{
						color = bmp.GetPixel(i, j);
						++R[color.R];
						++G[color.G];
						++B[color.B];
					}
				// находим самый высокий столбец, чтобы корректно масштабировать гистограмму по высоте
				int max = 0;
				for (i = 0; i < 256; ++i)
				{
					if (R[i] > max)
						max = R[i];
					if (G[i] > max)
						max = G[i];
					if (B[i] > max)
						max = B[i];
				}
				// определяем коэффициент масштабирования по высоте
				double point = (double)max / height;
				// отрисовываем столбец за столбцом нашу гистограмму с учетом масштаба
				for (i = 0; i < width - 3; ++i)
				{
					for (j = height - 1; j > height - R[i / 3] / point; --j)
					{
						//for (i=0;i<3;i++)
						barChart.SetPixel(i, j, Color.Red);
						
					}
					++i;
					for (j = height - 1; j > height - G[i / 3] / point; --j)
					{
						//for (i = 0; i < 3; i++)
							barChart.SetPixel(i, j, Color.Green);
						
					}
					++i;
					for (j = height - 1; j > height - B[i / 3] / point; --j)
					{
						//for (i = 0; i < 3; i++)
							barChart.SetPixel(i, j, Color.Blue);
						
					}
				}
			}
			else
				barChart = new Bitmap(1, 1);
			return barChart;
		}

		private void открытиеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MathMorf mathmorf = new MathMorf();
			Bitmap resultImage = mathmorf.processImage(image);
			Erozia erozia = new Erozia();
			resultImage = erozia.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();

		}

		private void закрытиеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Erozia erozia = new Erozia();
			Bitmap resultImage = erozia.processImage(image);
			MathMorf mathmorf = new MathMorf();
			resultImage = mathmorf.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();
		}

		private void градиентГраницаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GradientBorder gradientBorder = new GradientBorder();
			gradientBorder.EdgeDetection(image,10);
			pictureBox1.Refresh();
		}
	}
}
