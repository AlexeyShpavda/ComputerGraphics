using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ComputerGraphics.ImageProcessing
{
    public class ImageHandler
    {
        public Bitmap Image { get; set; }

        public ImageHandler(Bitmap image)
        {
            Image = image;
        }

        public Bitmap Scale(double widthFactor, double heightFactor)
        {
            var scaledImage = new Bitmap((int)(Image.Width * widthFactor), (int)(Image.Height * heightFactor));

            for (var x = 0; x < scaledImage.Width; x++)
            {
                for (var y = 0; y < scaledImage.Height; y++)
                {
                    scaledImage.SetPixel(x, y, Image.GetPixel((int)(x / widthFactor), (int)(y / heightFactor)));
                }
            }

            Image = scaledImage;

            return scaledImage;
        }

        public Bitmap Rotate(double angle)
        {
            var newImage = new Bitmap(Convert.ToInt32(Math.Sqrt(Image.Height * Image.Height + Image.Width * Image.Width)),
                Convert.ToInt32(Math.Sqrt(Image.Height * Image.Height + Image.Width * Image.Width)));

            var angleRadian = angle * Math.PI / 180;

            var z = Convert.ToInt32((Math.Sqrt(Image.Height * Image.Height + Image.Width * Image.Width) - Image.Width) / 2);
            var c = Convert.ToInt32((Math.Sqrt(Image.Height * Image.Height + Image.Width * Image.Width) - Image.Height) / 2);

            for (double j = 0; j < Image.Height - 1; j += (1 / Math.Sqrt(2)))
            {
                for (double i = 0; i < Image.Width - 1; i += (1 / Math.Sqrt(2)))
                {
                    var x = Convert.ToInt32(((i - Image.Width / 2.0) * Math.Cos(angleRadian) -
                                             (j - Image.Height / 2.0) * Math.Sin(angleRadian) + Image.Width / 2.0));
                    var y = Convert.ToInt32(((i - Image.Width / 2.0) * Math.Sin(angleRadian) +
                                             (j - Image.Height / 2.0) * Math.Cos(angleRadian) + Image.Height / 2.0));

                    newImage.SetPixel(x + z, y + c, Image.GetPixel(Convert.ToInt32(i), Convert.ToInt32(j)));
                }
            }

            Image = newImage;

            return newImage;
        }

        public Bitmap MedianFilter(int cellSize)
        {
            var newImage = new Bitmap(Image.Width, Image.Height);

            var minValue = -(cellSize / 2);
            var maxValue = (cellSize / 2);

            for (var x = 0; x < newImage.Width; x++)
            {
                for (var y = 0; y < newImage.Height; y++)
                {
                    var colors = new List<Tuple<double, double, double>>();

                    for (var x2 = minValue; x2 < maxValue; x2++)
                    {
                        var tempX = x + x2;

                        if (tempX < 0 || tempX >= newImage.Width) continue;
                        for (var y2 = minValue; y2 < maxValue; y2++)
                        {
                            var tempY = y + y2;

                            if (tempY < 0 || tempY >= newImage.Height) continue;
                            var tempColor = Image.GetPixel(tempX, tempY);

                            colors.Add(FromRgbToLab(tempColor));
                        }
                    }

                    var rgbPixel = FromLabToRgb(colors.OrderBy(color => color.Item1).ToList()[colors.Count / 2].Item1,
                        colors.OrderBy(color => color.Item2).ToList()[colors.Count / 2].Item2,
                        colors.OrderBy(color => color.Item3).ToList()[colors.Count / 2].Item3);

                    var newRgbPixel = Color.FromArgb(rgbPixel.Item1, rgbPixel.Item2, rgbPixel.Item3);

                    //var medianPixel = Color.FromArgb(
                    //    colors.OrderBy(color => color.Item1).ToList()[colors.Count / 2].Item1,
                    //    colors.OrderBy(color => color.Item2).ToList()[colors.Count / 2].Item2,
                    //    colors.OrderBy(color => color.Item3).ToList()[colors.Count / 2].Item3);

                    newImage.SetPixel(x, y, newRgbPixel);
                }
            }

            //Image = newImage;

            return newImage;
        }

        public Bitmap Convolution(double[,] matrix, double div)
        {
            var newImage = new Bitmap(Image.Width, Image.Height);

            var maxValue = (int)(Math.Sqrt(matrix.Length) / 2);

            for (var x = maxValue; x < newImage.Width - maxValue; x++)
            {
                for (var y = maxValue; y < newImage.Height - maxValue; y++)
                {
                    var colors = new List<Tuple<double,double,double>>();

                    for (var x2 = x - maxValue; x2 <= x + maxValue; x2++)
                    {
                        for (var y2 = y - maxValue; y2 <= y + maxValue; y2++)
                        {
                            var tempColor = Image.GetPixel(x2, y2);

                            colors.Add(FromRgbToLab(tempColor));
                        }
                    }

                    if (colors.Count != 9) continue;

                    var tempR = (colors[0].Item1 * matrix[0, 0] + colors[1].Item1 * matrix[0, 1] + colors[2].Item1 * matrix[0, 2] +
                                 colors[3].Item1* matrix[1, 0] + colors[4].Item1 * matrix[1, 1] + colors[5].Item1 * matrix[1, 2] +
                                 colors[6].Item1 * matrix[2, 0] + colors[7].Item1 * matrix[2, 1] + colors[8].Item1 * matrix[2, 2]) /
                                div;

                    var tempG = (colors[0].Item2 * matrix[0, 0] + colors[1].Item2 * matrix[0, 1] + colors[2].Item2 * matrix[0, 2] +
                                 colors[3].Item2 * matrix[1, 0] + colors[4].Item2 * matrix[1, 1] + colors[5].Item2 * matrix[1, 2] +
                                 colors[6].Item2 * matrix[2, 0] + colors[7].Item2 * matrix[2, 1] + colors[8].Item2 * matrix[2, 2]) / div;

                    var tempB = (colors[0].Item3 * matrix[0, 0] + colors[1].Item3 * matrix[0, 1] + colors[2].Item3 * matrix[0, 2] +
                                 colors[3].Item3 * matrix[1, 0] + colors[4].Item3 * matrix[1, 1] + colors[5].Item3 * matrix[1, 2] +
                                 colors[6].Item3 * matrix[2, 0] + colors[7].Item3 * matrix[2, 1] + colors[8].Item3 * matrix[2, 2]) / div;

                    var pixelColors = FromLabToRgb(tempR, tempG, tempB);
                    //var pixel = Color.FromArgb(pixelColors.Item1, pixelColors.Item2, pixelColors.Item3);
                    //var pixel = Color.FromArgb(
                    //    (int)(tempR > 255 ? 255 : (tempR < 0) ? 0 : tempR),
                    //    (int)(tempG > 255 ? 255 : (tempG < 0) ? 0 : tempG),
                    //    (int)(tempB > 255 ? 255 : (tempB < 0) ? 0 : tempB));

                    var pixel = Color.FromArgb(
                        (pixelColors.Item1 > 255 ? 255 : (pixelColors.Item1 < 0) ? 0 : pixelColors.Item1),
                        (pixelColors.Item2 > 255 ? 255 : (pixelColors.Item2 < 0) ? 0 : pixelColors.Item2),
                        (pixelColors.Item3 > 255 ? 255 : (pixelColors.Item3 < 0) ? 0 : pixelColors.Item3));

                    newImage.SetPixel(x, y, pixel);
                }
            }

            //Image = newImage;

            return newImage;
        }

        public Bitmap Monochrome()
        {
            var newImage = new Bitmap(Image.Width, Image.Height);

            for (var x = 0; x < Image.Width; x++)
            {
                for (var y = 0; y < Image.Height; y++)
                {
                    var pixel = Image.GetPixel(x, y);

                    var labPixels = FromRgbToLab(pixel);

                    var average = (int)((labPixels.Item1 + labPixels.Item2 + labPixels.Item3) / 3.0);

                    int l = (int)labPixels.Item1, a = 0, b = 0;

                    var rgbPixels = FromLabToRgb(l, a, b);

                    var newPixel = Color.FromArgb(
                        (rgbPixels.Item1 > 255 ? 255 : (rgbPixels.Item1 < 0) ? 0 : rgbPixels.Item1),
                        (rgbPixels.Item2 > 255 ? 255 : (rgbPixels.Item2 < 0) ? 0 : rgbPixels.Item2),
                        (rgbPixels.Item3 > 255 ? 255 : (rgbPixels.Item3 < 0) ? 0 : rgbPixels.Item3));

                    newImage.SetPixel(x, y, newPixel);
                }
            }

            //Image = newImage;

            return newImage;
        }

        private static Tuple<double, double, double> FromRgbToLab(Color f)
        {
            var r = Convert.ToDouble(f.R) / 255;
            var g = Convert.ToDouble(f.G) / 255;
            var b = Convert.ToDouble(f.B) / 255;

            if (r > 0.04045) { r = Math.Pow(((r + 0.055) / 1.055), 2.4); }
            else r = r / 12.92;
            if (g > 0.04045) { g = Math.Pow(((g + 0.055) / 1.055), 2.4); }
            else g = g / 12.92;
            if (b > 0.04045) { b = Math.Pow(((b + 0.055) / 1.055), 2.4); }
            else b = b / 12.92;

            r = r * 100;
            g = g * 100;
            b = b * 100;

            var x = r * 0.4124 + g * 0.3576 + b * 0.1805;
            var y = r * 0.2126 + g * 0.7152 + b * 0.0722;
            var z = r * 0.0193 + g * 0.1192 + b * 0.9505;

            var xq = x / 95.047;
            var yq = y / 100;
            var zq = z / 108.883;

            if (xq > 0.008856) xq = Math.Pow(xq, 0.33333);
            else xq = (7.787 * xq) + (16.0 / 116.0);
            if (yq > 0.008856) yq = Math.Pow(yq, 0.33333);
            else yq = (7.787 * yq) + (16.0 / 116.0);
            if (zq > 0.008856) zq = Math.Pow(zq, 0.33333);
            else zq = (7.787 * zq) + (16.0 / 116.0);

            var labL = (116 * yq) - 16;
            var labA = 500 * (xq - yq);
            var labB = 200 * (yq - zq);

            return Tuple.Create(labL, labA, labB);
        }

        private static Tuple<int, int, int> FromLabToRgb(double labL, double labA, double labB)
        {
            var varY = (labL + 16) / 116;
            var varX = labA / 500 + varY;
            var varZ = varY - labB / 200;

            if (Math.Pow(varY, 3) > 0.008856) varY = Math.Pow(varY, 3);
            else varY = (varY - 16.0 / 116.0) / (7.787);

            if (Math.Pow(varX, 3) > 0.008856) varX = Math.Pow(varX, 3);
            else varX = (varX - 16.0 / 116.0) / (7.787);

            if (Math.Pow(varZ, 3) > 0.008856) varZ = Math.Pow(varZ, 3);
            else varZ = (varZ - 16.0 / 116.0) / (7.787);

            var x = varX * 95.047;
            var y = varY * 100;
            var z = varZ * 108.883;

            varX = x / 100;
            varY = y / 100;
            varZ = z / 100;

            var varR = varX * 3.2406 + varY * (-1.5372) + varZ * (-0.4986);
            var varG = varX * (-0.9689) + varY * 1.8758 + varZ * 0.0415;
            var varB = varX * 0.0557 + varY * -0.2040 + varZ * 1.0570;

            if (varR > 0.0031308) varR = 1.055 * Math.Pow(varR, 1 / 2.4) - 0.055;
            else varR = 12.92 * varR;
            if (varG > 0.0031308) varG = 1.055 * Math.Pow(varG, 1 / 2.4) - 0.055;
            else varG = 12.92 * varG;
            if (varB > 0.0031308) varB = 1.055 * Math.Pow(varB, 1 / 2.4) - 0.055;
            else varB = 12.92 * varB;

            var r = Convert.ToInt32(Math.Round(varR * 255));
            var g = Convert.ToInt32(Math.Round(varG * 255));
            var b = Convert.ToInt32(Math.Round(varB * 255));

            return Tuple.Create(r, g, b);
        }
    }
}