using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//где то тут есть погрешность, в числах не вижу где, но она на уровне красного канала
namespace aaaaaaaaaa
{
	internal class FromRGBtoLab : Filter
	{

		protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
		{

			Color sourceColor = sourceImage.GetPixel(x, y);//Просто получаем пиксели
			//из RGB в Lab
			double var_R = sourceColor.R / 255.0;
			double var_G = sourceColor.G / 255.0;
			double var_B = sourceColor.B / 255.0;

			if (var_R > 0.04045) var_R = Math.Pow(((var_R + 0.055) / 1.055), 2.4);
			else var_R = var_R / 12.92;

			if (var_G > 0.04045) var_G = Math.Pow(((var_G + 0.055) / 1.055), 2.4);
			else var_G = var_G / 12.92;

			if (var_B > 0.04045) var_B = Math.Pow(((var_B + 0.055) / 1.055), 2.4);
			else var_B = var_B / 12.92;

			double X = (var_R * 0.4124 + var_G * 0.3576 + var_B * 0.1805)/0.95047;
			double Y = (var_R * 0.2126 + var_G * 0.7152 + var_B * 0.0722)/1.0;
			double Z = (var_R * 0.0193 + var_G * 0.1192 + var_B * 0.9505)/1.08883;

			if (X > 0.008856) X = Math.Pow(X, 0.3333);
			else X = (7.787 * X) + (16 / 116);

			if (Y > 0.008856) Y = Math.Pow(Y, 0.3333);
			else Y = (7.787 * Y) + (16 / 116);

			if (Z > 0.008856) Z = Math.Pow(Z, 0.3333);
			else Z = (7.787 * Z) + (16 / 116);

			double L = (116 * Y)-16 ;
			double A = 500 * (X - Y);
			double B = 200 * (Y - Z);

			//Если раскомментировать это и закомментировать следующие действия до (79)resultImage, то все изображение будет тупо черным
			//Нужно оно только, чтобы показать, что картинка в принципе меняется при конвертации
			//Color resultColor = Color.FromArgb((int)Math.Max(0, Math.Min(1, L)), (int)Math.Max(0, Math.Min(1, A)), (int)Math.Max(0, Math.Min(1, B)));

			//из Lab в RGB
			Y = (L + 16) / 116;
			X = A / 500 + Y;
			Z = Y - B / 200;

			if (Math.Pow(Y, 3.0) > 0.008856) Y = Math.Pow(Y, 3);
			else Y = (Y - 16 / 116) / 7.787;

			if (Math.Pow(X, 3.0) > 0.008856) X = Math.Pow(X, 3);
			else X = (X - 16 / 116) / 7.787;

			if (Math.Pow(Z, 3.0) > 0.008856) Z = Math.Pow(Z, 3);
			else Z = (Z - 16 / 116) / 7.787;

			var_R = X * 3.2406 + Y * -1.5372 + Z * -0.4986;
			var_G = X * -0.9689 + Y * 1.8758 + Z * 0.0415;
			var_B = X * 0.0557 + Y * -0.2040 + Z * 1.0570;

			if (var_R > 0.0031308) var_R = 1.055 * Math.Pow(var_R, 0.41666667) - 0.055;
			else var_R = 12.92 * var_R;

			if (var_G > 0.0031308) var_G = 1.055 * Math.Pow(var_G, 0.41666667) - 0.055;
			else var_G = 12.92 * var_G;

			if (var_B > 0.0031308) var_B = 1.055 * Math.Pow(var_B, 0.41666667) - 0.055;
			else var_B = 12.92 * var_B;

			Color resultColor = Color.FromArgb((int)Math.Max(0, Math.Min(1, var_R) * 255), (int)Math.Max(0, Math.Min(1, var_G) * 255), (int)Math.Max(0, Math.Min(1, var_B) * 255));
			return resultColor;
		}
	}
}
