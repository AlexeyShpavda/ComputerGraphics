namespace ImageProcessor.PL.FormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.scaleButton = new System.Windows.Forms.Button();
            this.imageWidthTextBox = new System.Windows.Forms.TextBox();
            this.imageHeightTextBox = new System.Windows.Forms.TextBox();
            this.widthImageLabel = new System.Windows.Forms.Label();
            this.heightImageLabel = new System.Windows.Forms.Label();
            this.medianFilterButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.rotationAngleLabel = new System.Windows.Forms.Label();
            this.rotationAngleTextBox = new System.Windows.Forms.TextBox();
            this.monochromeButton = new System.Windows.Forms.Button();
            this.convolutionButton = new System.Windows.Forms.Button();
            this.medianFilterTextBox = new System.Windows.Forms.TextBox();
            this.convolutionTextBox11 = new System.Windows.Forms.TextBox();
            this.convolutionTextBox12 = new System.Windows.Forms.TextBox();
            this.convolutionTextBox13 = new System.Windows.Forms.TextBox();
            this.convolutionTextBox23 = new System.Windows.Forms.TextBox();
            this.convolutionTextBox22 = new System.Windows.Forms.TextBox();
            this.convolutionTextBox21 = new System.Windows.Forms.TextBox();
            this.convolutionTextBox33 = new System.Windows.Forms.TextBox();
            this.convolutionTextBox32 = new System.Windows.Forms.TextBox();
            this.convolutionTextBox31 = new System.Windows.Forms.TextBox();
            this.convolutionTextBoxDiv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.lineRotationButton = new System.Windows.Forms.Button();
            this.timerForRotation = new System.Windows.Forms.Timer(this.components);
            this.polygonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(16, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1079, 477);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.LightGray;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.ForeColor = System.Drawing.Color.DarkRed;
            this.openButton.Location = new System.Drawing.Point(16, 512);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 28);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "OPEN";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightGray;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.DarkRed;
            this.saveButton.Location = new System.Drawing.Point(116, 512);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // scaleButton
            // 
            this.scaleButton.BackColor = System.Drawing.Color.LightGray;
            this.scaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleButton.ForeColor = System.Drawing.Color.DarkRed;
            this.scaleButton.Location = new System.Drawing.Point(224, 513);
            this.scaleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(100, 28);
            this.scaleButton.TabIndex = 3;
            this.scaleButton.Text = "SCALE";
            this.scaleButton.UseVisualStyleBackColor = false;
            this.scaleButton.Click += new System.EventHandler(this.ScaleButton_Click);
            // 
            // imageWidthTextBox
            // 
            this.imageWidthTextBox.Location = new System.Drawing.Point(325, 516);
            this.imageWidthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageWidthTextBox.Name = "imageWidthTextBox";
            this.imageWidthTextBox.Size = new System.Drawing.Size(45, 22);
            this.imageWidthTextBox.TabIndex = 4;
            // 
            // imageHeightTextBox
            // 
            this.imageHeightTextBox.Location = new System.Drawing.Point(377, 516);
            this.imageHeightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageHeightTextBox.Name = "imageHeightTextBox";
            this.imageHeightTextBox.Size = new System.Drawing.Size(49, 22);
            this.imageHeightTextBox.TabIndex = 5;
            // 
            // widthImageLabel
            // 
            this.widthImageLabel.AutoSize = true;
            this.widthImageLabel.Location = new System.Drawing.Point(325, 500);
            this.widthImageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthImageLabel.Name = "widthImageLabel";
            this.widthImageLabel.Size = new System.Drawing.Size(48, 17);
            this.widthImageLabel.TabIndex = 6;
            this.widthImageLabel.Text = "Width:";
            // 
            // heightImageLabel
            // 
            this.heightImageLabel.AutoSize = true;
            this.heightImageLabel.Location = new System.Drawing.Point(377, 500);
            this.heightImageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightImageLabel.Name = "heightImageLabel";
            this.heightImageLabel.Size = new System.Drawing.Size(53, 17);
            this.heightImageLabel.TabIndex = 7;
            this.heightImageLabel.Text = "Height:";
            // 
            // medianFilterButton
            // 
            this.medianFilterButton.BackColor = System.Drawing.Color.LightGray;
            this.medianFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medianFilterButton.ForeColor = System.Drawing.Color.DarkRed;
            this.medianFilterButton.Location = new System.Drawing.Point(596, 514);
            this.medianFilterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medianFilterButton.Name = "medianFilterButton";
            this.medianFilterButton.Size = new System.Drawing.Size(163, 28);
            this.medianFilterButton.TabIndex = 8;
            this.medianFilterButton.Text = "MEDIAN FILTER";
            this.medianFilterButton.UseVisualStyleBackColor = false;
            this.medianFilterButton.Click += new System.EventHandler(this.MedianFilterButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.BackColor = System.Drawing.Color.LightGray;
            this.rotateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateButton.ForeColor = System.Drawing.Color.DarkRed;
            this.rotateButton.Location = new System.Drawing.Point(436, 514);
            this.rotateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(100, 28);
            this.rotateButton.TabIndex = 9;
            this.rotateButton.Text = "ROTATE";
            this.rotateButton.UseVisualStyleBackColor = false;
            this.rotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // rotationAngleLabel
            // 
            this.rotationAngleLabel.AutoSize = true;
            this.rotationAngleLabel.Location = new System.Drawing.Point(539, 498);
            this.rotationAngleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotationAngleLabel.Name = "rotationAngleLabel";
            this.rotationAngleLabel.Size = new System.Drawing.Size(48, 17);
            this.rotationAngleLabel.TabIndex = 10;
            this.rotationAngleLabel.Text = "Angle:";
            // 
            // rotationAngleTextBox
            // 
            this.rotationAngleTextBox.Location = new System.Drawing.Point(539, 516);
            this.rotationAngleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rotationAngleTextBox.Name = "rotationAngleTextBox";
            this.rotationAngleTextBox.Size = new System.Drawing.Size(48, 22);
            this.rotationAngleTextBox.TabIndex = 11;
            // 
            // monochromeButton
            // 
            this.monochromeButton.BackColor = System.Drawing.Color.LightGray;
            this.monochromeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monochromeButton.ForeColor = System.Drawing.Color.DarkRed;
            this.monochromeButton.Location = new System.Drawing.Point(812, 514);
            this.monochromeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monochromeButton.Name = "monochromeButton";
            this.monochromeButton.Size = new System.Drawing.Size(140, 28);
            this.monochromeButton.TabIndex = 12;
            this.monochromeButton.Text = "MONOCHROME";
            this.monochromeButton.UseVisualStyleBackColor = false;
            this.monochromeButton.Click += new System.EventHandler(this.MonochromeButton_Click);
            // 
            // convolutionButton
            // 
            this.convolutionButton.BackColor = System.Drawing.Color.LightGray;
            this.convolutionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convolutionButton.ForeColor = System.Drawing.Color.DarkRed;
            this.convolutionButton.Location = new System.Drawing.Point(1135, 15);
            this.convolutionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionButton.Name = "convolutionButton";
            this.convolutionButton.Size = new System.Drawing.Size(140, 28);
            this.convolutionButton.TabIndex = 13;
            this.convolutionButton.Text = "CONVOLUTION";
            this.convolutionButton.UseVisualStyleBackColor = false;
            this.convolutionButton.Click += new System.EventHandler(this.ConvolutionButton_Click);
            // 
            // medianFilterTextBox
            // 
            this.medianFilterTextBox.Location = new System.Drawing.Point(760, 516);
            this.medianFilterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medianFilterTextBox.Name = "medianFilterTextBox";
            this.medianFilterTextBox.Size = new System.Drawing.Size(43, 22);
            this.medianFilterTextBox.TabIndex = 14;
            // 
            // convolutionTextBox11
            // 
            this.convolutionTextBox11.Location = new System.Drawing.Point(1135, 50);
            this.convolutionTextBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionTextBox11.Name = "convolutionTextBox11";
            this.convolutionTextBox11.Size = new System.Drawing.Size(40, 22);
            this.convolutionTextBox11.TabIndex = 15;
            // 
            // convolutionTextBox12
            // 
            this.convolutionTextBox12.Location = new System.Drawing.Point(1184, 50);
            this.convolutionTextBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionTextBox12.Name = "convolutionTextBox12";
            this.convolutionTextBox12.Size = new System.Drawing.Size(40, 22);
            this.convolutionTextBox12.TabIndex = 16;
            // 
            // convolutionTextBox13
            // 
            this.convolutionTextBox13.Location = new System.Drawing.Point(1233, 50);
            this.convolutionTextBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionTextBox13.Name = "convolutionTextBox13";
            this.convolutionTextBox13.Size = new System.Drawing.Size(40, 22);
            this.convolutionTextBox13.TabIndex = 17;
            // 
            // convolutionTextBox23
            // 
            this.convolutionTextBox23.Location = new System.Drawing.Point(1233, 82);
            this.convolutionTextBox23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionTextBox23.Name = "convolutionTextBox23";
            this.convolutionTextBox23.Size = new System.Drawing.Size(40, 22);
            this.convolutionTextBox23.TabIndex = 20;
            // 
            // convolutionTextBox22
            // 
            this.convolutionTextBox22.Location = new System.Drawing.Point(1184, 82);
            this.convolutionTextBox22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionTextBox22.Name = "convolutionTextBox22";
            this.convolutionTextBox22.Size = new System.Drawing.Size(40, 22);
            this.convolutionTextBox22.TabIndex = 19;
            // 
            // convolutionTextBox21
            // 
            this.convolutionTextBox21.Location = new System.Drawing.Point(1135, 82);
            this.convolutionTextBox21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionTextBox21.Name = "convolutionTextBox21";
            this.convolutionTextBox21.Size = new System.Drawing.Size(40, 22);
            this.convolutionTextBox21.TabIndex = 18;
            // 
            // convolutionTextBox33
            // 
            this.convolutionTextBox33.Location = new System.Drawing.Point(1233, 114);
            this.convolutionTextBox33.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionTextBox33.Name = "convolutionTextBox33";
            this.convolutionTextBox33.Size = new System.Drawing.Size(40, 22);
            this.convolutionTextBox33.TabIndex = 23;
            // 
            // convolutionTextBox32
            // 
            this.convolutionTextBox32.Location = new System.Drawing.Point(1184, 114);
            this.convolutionTextBox32.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionTextBox32.Name = "convolutionTextBox32";
            this.convolutionTextBox32.Size = new System.Drawing.Size(40, 22);
            this.convolutionTextBox32.TabIndex = 22;
            // 
            // convolutionTextBox31
            // 
            this.convolutionTextBox31.Location = new System.Drawing.Point(1135, 114);
            this.convolutionTextBox31.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionTextBox31.Name = "convolutionTextBox31";
            this.convolutionTextBox31.Size = new System.Drawing.Size(40, 22);
            this.convolutionTextBox31.TabIndex = 21;
            // 
            // convolutionTextBoxDiv
            // 
            this.convolutionTextBoxDiv.Location = new System.Drawing.Point(1184, 146);
            this.convolutionTextBoxDiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convolutionTextBoxDiv.Name = "convolutionTextBoxDiv";
            this.convolutionTextBoxDiv.Size = new System.Drawing.Size(40, 22);
            this.convolutionTextBoxDiv.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(763, 498);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Size:";
            // 
            // lineButton
            // 
            this.lineButton.BackColor = System.Drawing.Color.LightGray;
            this.lineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineButton.ForeColor = System.Drawing.Color.DarkRed;
            this.lineButton.Location = new System.Drawing.Point(1125, 251);
            this.lineButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(163, 28);
            this.lineButton.TabIndex = 26;
            this.lineButton.Text = "LINE";
            this.lineButton.UseVisualStyleBackColor = false;
            this.lineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LightGray;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.DarkRed;
            this.clearButton.Location = new System.Drawing.Point(1125, 433);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(163, 28);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // lineRotationButton
            // 
            this.lineRotationButton.BackColor = System.Drawing.Color.LightGray;
            this.lineRotationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineRotationButton.ForeColor = System.Drawing.Color.DarkRed;
            this.lineRotationButton.Location = new System.Drawing.Point(1125, 287);
            this.lineRotationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineRotationButton.Name = "lineRotationButton";
            this.lineRotationButton.Size = new System.Drawing.Size(163, 28);
            this.lineRotationButton.TabIndex = 28;
            this.lineRotationButton.Text = "LINE ROTATION";
            this.lineRotationButton.UseVisualStyleBackColor = false;
            this.lineRotationButton.Click += new System.EventHandler(this.LineRotationButton_Click);
            // 
            // timerForRotation
            // 
            this.timerForRotation.Interval = 1;
            this.timerForRotation.Tick += new System.EventHandler(this.TimerForRotation_Tick);
            // 
            // polygonButton
            // 
            this.polygonButton.BackColor = System.Drawing.Color.LightGray;
            this.polygonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polygonButton.ForeColor = System.Drawing.Color.DarkRed;
            this.polygonButton.Location = new System.Drawing.Point(1125, 341);
            this.polygonButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(163, 28);
            this.polygonButton.TabIndex = 29;
            this.polygonButton.Text = "POLYGON";
            this.polygonButton.UseVisualStyleBackColor = false;
            this.polygonButton.Click += new System.EventHandler(this.polygonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1313, 559);
            this.Controls.Add(this.polygonButton);
            this.Controls.Add(this.lineRotationButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convolutionTextBoxDiv);
            this.Controls.Add(this.convolutionTextBox33);
            this.Controls.Add(this.convolutionTextBox32);
            this.Controls.Add(this.convolutionTextBox31);
            this.Controls.Add(this.convolutionTextBox23);
            this.Controls.Add(this.convolutionTextBox22);
            this.Controls.Add(this.convolutionTextBox21);
            this.Controls.Add(this.convolutionTextBox13);
            this.Controls.Add(this.convolutionTextBox12);
            this.Controls.Add(this.convolutionTextBox11);
            this.Controls.Add(this.medianFilterTextBox);
            this.Controls.Add(this.convolutionButton);
            this.Controls.Add(this.monochromeButton);
            this.Controls.Add(this.rotationAngleTextBox);
            this.Controls.Add(this.rotationAngleLabel);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.medianFilterButton);
            this.Controls.Add(this.heightImageLabel);
            this.Controls.Add(this.widthImageLabel);
            this.Controls.Add(this.imageHeightTextBox);
            this.Controls.Add(this.imageWidthTextBox);
            this.Controls.Add(this.scaleButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button scaleButton;
        private System.Windows.Forms.TextBox imageWidthTextBox;
        private System.Windows.Forms.TextBox imageHeightTextBox;
        private System.Windows.Forms.Label widthImageLabel;
        private System.Windows.Forms.Label heightImageLabel;
        private System.Windows.Forms.Button medianFilterButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Label rotationAngleLabel;
        private System.Windows.Forms.TextBox rotationAngleTextBox;
        private System.Windows.Forms.Button monochromeButton;
        private System.Windows.Forms.Button convolutionButton;
        private System.Windows.Forms.TextBox medianFilterTextBox;
        private System.Windows.Forms.TextBox convolutionTextBox11;
        private System.Windows.Forms.TextBox convolutionTextBox12;
        private System.Windows.Forms.TextBox convolutionTextBox13;
        private System.Windows.Forms.TextBox convolutionTextBox23;
        private System.Windows.Forms.TextBox convolutionTextBox22;
        private System.Windows.Forms.TextBox convolutionTextBox21;
        private System.Windows.Forms.TextBox convolutionTextBox33;
        private System.Windows.Forms.TextBox convolutionTextBox32;
        private System.Windows.Forms.TextBox convolutionTextBox31;
        private System.Windows.Forms.TextBox convolutionTextBoxDiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button lineRotationButton;
        private System.Windows.Forms.Timer timerForRotation;
        private System.Windows.Forms.Button polygonButton;
    }
}

