using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using ComputerGraphics.ImageProcessing;
using ComputerGraphics.ObjectCreation;

namespace ComputerGraphics
{
    public partial class MainForm : Form
    {
        private int _x1, _y1;
        private int _x2, _y2;
        private int _x3, _y3;
        private int _x4, _y4;

        private Graphics Graphics { get; set; }
        private Bitmap Bitmap { get; }

        public MainForm()
        {
            InitializeComponent();
            Bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        public ImageHandler ImageHandler { get; private set; }

        public ObjectDrawer ObjectDrawer{ get; private set; }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            var formatsSuitableForOpening = ConfigurationManager.AppSettings["formatsSuitableForOpening"];
            var errorMessageWhenOpening = ConfigurationManager.AppSettings["errorMessageWhenOpening"];

            var openFileDialog = new OpenFileDialog {Filter = formatsSuitableForOpening};

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                ImageHandler = new ImageHandler(new Bitmap(openFileDialog.FileName));
                pictureBox.Image = ImageHandler.Image;
            }
            catch
            {
                MessageBox.Show(errorMessageWhenOpening, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            var formatsSuitableForSaving = ConfigurationManager.AppSettings["formatsSuitableForSaving"];
            var errorMessageWhenSaving = ConfigurationManager.AppSettings["errorMessageWhenSaving"];

            var saveFileDialog = new SaveFileDialog
            {
                OverwritePrompt = true,
                CheckPathExists = true,
                Filter = formatsSuitableForSaving
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                pictureBox.Image.Save(saveFileDialog.FileName);
            }
            catch
            {
                MessageBox.Show(errorMessageWhenSaving, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScaleButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null || imageWidthTextBox.Text == "" || imageHeightTextBox.Text == "") return;

            var widthFactor = double.Parse(imageWidthTextBox.Text.Replace(",", "."));
            var heightFactor = double.Parse(imageHeightTextBox.Text.Replace(",", "."));

            pictureBox.Image = ImageHandler.Scale(widthFactor, heightFactor);
        }

        private void MedianFilterButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null || medianFilterTextBox.Text == "") return;

            var cellSize = int.Parse(medianFilterTextBox.Text.Replace(",", "."));

            pictureBox.Image = ImageHandler.MedianFilter(cellSize);
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null || rotationAngleTextBox.Text == "") return;

            var angle = double.Parse(rotationAngleTextBox.Text.Replace(".", ","));

            if (angle.Equals(0.0) || angle.Equals(360.0)) return;

            pictureBox.Image = ImageHandler.Rotate(angle);
        }

        private void MonochromeButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            pictureBox.Image = ImageHandler.Monochrome();
        }

        private void ConvolutionButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            double[,] matrix;
            double div;

            try
            {
                var e11 = double.Parse(convolutionTextBox11.Text.Replace(",", "."));
                var e12 = double.Parse(convolutionTextBox12.Text.Replace(",", "."));
                var e13 = double.Parse(convolutionTextBox13.Text.Replace(",", "."));
                var e21 = double.Parse(convolutionTextBox21.Text.Replace(",", "."));
                var e22 = double.Parse(convolutionTextBox22.Text.Replace(",", "."));
                var e23 = double.Parse(convolutionTextBox23.Text.Replace(",", "."));
                var e31 = double.Parse(convolutionTextBox31.Text.Replace(",", "."));
                var e32 = double.Parse(convolutionTextBox32.Text.Replace(",", "."));
                var e33 = double.Parse(convolutionTextBox33.Text.Replace(",", "."));

                matrix = new[,] { { e11, e12, e13 }, { e21, e22, e23 }, { e31, e32, e33 } };

                div = double.Parse(convolutionTextBoxDiv.Text.Replace(",", "."));
            }
            catch
            {
                matrix = new[,] {{-1.0, -1.0, -1.0}, {-1.0, 9.0, -1.0}, {-1.0, -1.0, -1.0}};

                div = 1;
            }

            pictureBox.Image = ImageHandler.Convolution(matrix, div);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            ObjectDrawer = new ObjectDrawer();

            var random = new Random();
            _x1 = random.Next(pictureBox.Width);
            _x2 = random.Next(pictureBox.Width);
            _y1 = random.Next(pictureBox.Height);
            _y2 = random.Next(pictureBox.Height);

            ObjectDrawer.DrawLine(pictureBox.CreateGraphics(), Color.Black, _x1, _y1, _x2, _y2);
        }

        private void LineRotationButton_Click(object sender, EventArgs e)
        {
            ObjectDrawer = new ObjectDrawer();

            Graphics = Graphics.FromHwnd(pictureBox.Handle);

            _x2 = pictureBox.Width / 2;
            _y2 = (pictureBox.Height / 2) - 100;

            _x4 = pictureBox.Width / 2;
            _y4 = (pictureBox.Height / 2) + 100;

            //ObjectDrawer.DrawLine(Graphics, Color.Black, _x4, _y4, _x2, _y2);

            ObjectDrawer.DrawLine(Graphics, Color.Black, _x2, _y2, _x3, _y3);
            ObjectDrawer.DrawLine(Graphics, Color.Black, pictureBox.Width / 2, pictureBox.Height / 2, _x2, _y2);
            _x3 = _x2;
            _y3 = _y2 - 50;

            Graphics.FillRectangle(new SolidBrush(Color.Gray), 0, 0, pictureBox.Width, pictureBox.Height);

            timerForRotation.Enabled = true;
        }

        private void TimerForRotation_Tick(object sender, EventArgs e)
        {
            ObjectDrawer = new ObjectDrawer();

            Graphics.FillRectangle(new SolidBrush(Color.Gray), 0, 0, pictureBox.Width, pictureBox.Height);

            var firstPointCoordinates = ObjectDrawer.Rotation(_x4, _y4, pictureBox.Width / 2, pictureBox.Height / 2, 15);
            var secondPointCoordinates = ObjectDrawer.Rotation(_x2, _y2, pictureBox.Width / 2, pictureBox.Height / 2, 15);

            _x4 = firstPointCoordinates.Item1;
            _y4 = firstPointCoordinates.Item2;

            _x2 = secondPointCoordinates.Item1;
            _y2 = secondPointCoordinates.Item2;

            ObjectDrawer.DrawLine(Graphics, Color.Black, _x4, _y4, _x2, _y2);

            SmallLineRotation();
            ObjectDrawer.DrawLine(Graphics, Color.Black, pictureBox.Width / 2, pictureBox.Height / 2, _x2, _y2);
        }

        private void SmallLineRotation()
        {
            ObjectDrawer = new ObjectDrawer();

            var smallLinePointCoordinates = ObjectDrawer.Rotation(_x3, _y3, _x2, _y2, 10);

            _x3 = smallLinePointCoordinates.Item1;
            _y3 = smallLinePointCoordinates.Item2;

            ObjectDrawer.DrawLine(Graphics, Color.Black, _x2, _y2, _x3, _y3);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            timerForRotation.Enabled = false;
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            ObjectDrawer = new ObjectDrawer();

            var g = Graphics.FromImage(Bitmap);

            ObjectDrawer.DrawPolygon(g, pictureBox.Width, pictureBox.Height);

            pictureBox.Image = Bitmap;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            var location = e.Location;

            ObjectDrawer = new ObjectDrawer();
            ObjectDrawer.FloodFill(Bitmap, location, Color.Black);

            pictureBox.Refresh();
        }
    }
}
