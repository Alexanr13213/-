using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaaaaaaaaa
{
	public partial class Form1 : Form
	{
		Bitmap image;
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
				pictureBox1.Image = image;
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

		private void блюрToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Blur blur = new Blur();
			Bitmap resultImage = blur.processImage(image);
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

        private void волня30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Wave30 wave30 = new Wave30();
			Bitmap resultImage = wave30.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();
		}

        private void волня60ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Wave60 wave60 = new Wave60();
			Bitmap resultImage = wave60.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();
		}

        private void превиттToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Prewit prewit = new Prewit();
			Bitmap resultImage = prewit.processImage(image);
			pictureBox1.Image = resultImage;
			pictureBox1.Refresh();
		}

        //private void эквализаторToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //	Equalizator equal = new Equalizator();
        //	Color resultImage = equal.Equalization(image);
        //	pictureBox1. = resultImage;
        //	pictureBox1.Refresh();
        //}
    }
}
