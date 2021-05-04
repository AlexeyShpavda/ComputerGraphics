using System;
using System.Collections.Generic;
using System.Drawing;

namespace ComputerGraphics.ObjectCreation
{
    public class DrawingObject
    {
        public void DrawLine(Graphics g, Color color, int x1, int y1,
            int x2, int y2)
        {
            var deltaX = Math.Abs(x2 - x1);
            var deltaY = Math.Abs(y2 - y1);

            var signX = x1 < x2 ? 1 : -1;
            var signY = y1 < y2 ? 1 : -1;
            
            var error = deltaX - deltaY;

            while (x1 != x2 || y1 != y2)
            {
                g.FillRectangle(new SolidBrush(color), new Rectangle(x1, y1, 1, 1));

                var error2 = error * 2;
                
                if (error2 > -deltaY)
                {
                    error -= deltaY;
                    x1 += signX;
                }

                if (error2 < deltaX)
                {
                    error += deltaX;
                    y1 += signY;
                }
            }

            g.FillRectangle(new SolidBrush(color), new Rectangle(x2, y2, 1, 1));
        }

        public Tuple<int, int> Rotation(int xn, int yn, int x0, int y0, int angle)
        {
            var angleRadian = angle * Math.PI / 180;

            var x = Convert.ToInt32(((xn - x0) * Math.Cos(angleRadian) - (yn - y0) * Math.Sin(angleRadian) + x0));
            var y = Convert.ToInt32(((xn - x0) * Math.Sin(angleRadian) + (yn - y0) * Math.Cos(angleRadian) + y0));

            return Tuple.Create(x, y);
        }

        public void DrawPolygon(Graphics g, int pictureBoxWidth, int pictureBoxHeight)
        {
            g.FillRectangle(new SolidBrush(Color.Gray), 0, 0, pictureBoxWidth, pictureBoxHeight);

            var random = new Random();

            var x1 = random.Next(pictureBoxWidth);
            var x2 = random.Next(pictureBoxWidth);

            if (x1 > x2) { var k = x2; x2 = x1; x1 = k; }

            var y1 = random.Next(pictureBoxHeight);
            var y2 = y1;

            var totalLength = x2 - x1;

            var pointsAmount = random.Next(1, 3);

            var segmentLength = Convert.ToInt32(totalLength / (pointsAmount + 1)) + 1;

            var points = new List<Point> {new Point(x1, y1)};

            for (var xi = (x1 + segmentLength); xi < x2; xi += segmentLength)
            {
                points.Add(new Point(xi, y1 - random.Next(0, y1)));
            }

            points.Add(new Point(x2, y2));

            for (var xi = (x2 - segmentLength); xi > x1; xi -= segmentLength)
            {
                points.Add(new Point(xi, y1 + random.Next(0, pictureBoxHeight - y1)));
            }

            for (var l = 0; l < (points.Count - 1); l++)
            {
                DrawLine(g, Color.Black, points[l].X, points[l].Y, points[l + 1].X, points[l + 1].Y);

                if (l == points.Count - 2)
                {
                    DrawLine(g, Color.Black, points[points.Count - 1].X, points[points.Count - 1].Y, x1, y1);
                }
            }
        }

        public void FloodFill(Bitmap image, Point pt, Color replacementColor)
        {
            var targetColor = image.GetPixel(pt.X, pt.Y);

            if (targetColor.ToArgb().Equals(replacementColor.ToArgb())) return;

            var pixels = new Stack<Point>();

            pixels.Push(pt);
            while (pixels.Count != 0)
            {
                var temp = pixels.Pop();

                var y1 = temp.Y;

                while (y1 >= 0 && image.GetPixel(temp.X, y1) == targetColor)
                {
                    y1--;
                }

                y1++;

                var spanLeft = false;
                var spanRight = false;

                while (y1 < image.Height && image.GetPixel(temp.X, y1) == targetColor)
                {
                    image.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && image.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));
                        spanLeft = true;
                    }
                    else if (spanLeft && temp.X - 1 == 0 && image.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }
                    if (!spanRight && temp.X < image.Width - 1 && image.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));
                        spanRight = true;
                    }
                    else if (spanRight && temp.X < image.Width - 1 && image.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }

                    y1++;
                }
            }
        }
    }
}