namespace INFOIBV
{
    partial class INFOIBV
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
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageFileName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Grayscale = new System.Windows.Forms.CheckBox();
            this.GFsize = new System.Windows.Forms.TextBox();
            this.GFsigma = new System.Windows.Forms.TextBox();
            this.GaussianFilter = new System.Windows.Forms.CheckBox();
            this.BinaryImage = new System.Windows.Forms.CheckBox();
            this.Threshold = new System.Windows.Forms.TextBox();
            this.EdgeDetection = new System.Windows.Forms.CheckBox();
            this.BorderHandling = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nonlinear = new System.Windows.Forms.CheckBox();
            this.ContrastAdjustment = new System.Windows.Forms.CheckBox();
            this.NLsize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(16, 15);
            this.LoadImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(131, 28);
            this.LoadImageButton.TabIndex = 0;
            this.LoadImageButton.Text = "Load image...";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Bitmap files (*.bmp;*.gif;*.jpg;*.png;*.tiff;*.jpeg)|*.bmp;*.gif;*.jpg;*.png;*.ti" +
    "ff;*.jpeg";
            this.openImageDialog.InitialDirectory = "..\\..\\images";
            // 
            // imageFileName
            // 
            this.imageFileName.Location = new System.Drawing.Point(155, 17);
            this.imageFileName.Margin = new System.Windows.Forms.Padding(4);
            this.imageFileName.Name = "imageFileName";
            this.imageFileName.ReadOnly = true;
            this.imageFileName.Size = new System.Drawing.Size(420, 22);
            this.imageFileName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 190);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(637, 15);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(137, 28);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.Filter = "Bitmap file (*.bmp)|*.bmp";
            this.saveImageDialog.InitialDirectory = "..\\..\\images";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1264, 14);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 28);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save as BMP...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(686, 190);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(550, 550);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(783, 17);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(368, 25);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // Grayscale
            // 
            this.Grayscale.AutoSize = true;
            this.Grayscale.Location = new System.Drawing.Point(17, 65);
            this.Grayscale.Margin = new System.Windows.Forms.Padding(4);
            this.Grayscale.Name = "Grayscale";
            this.Grayscale.Size = new System.Drawing.Size(94, 21);
            this.Grayscale.TabIndex = 7;
            this.Grayscale.Text = "Grayscale";
            this.Grayscale.UseVisualStyleBackColor = true;
            // 
            // GFsize
            // 
            this.GFsize.Location = new System.Drawing.Point(389, 95);
            this.GFsize.Margin = new System.Windows.Forms.Padding(4);
            this.GFsize.Name = "GFsize";
            this.GFsize.Size = new System.Drawing.Size(49, 22);
            this.GFsize.TabIndex = 12;
            // 
            // GFsigma
            // 
            this.GFsigma.Location = new System.Drawing.Point(465, 95);
            this.GFsigma.Margin = new System.Windows.Forms.Padding(4);
            this.GFsigma.Name = "GFsigma";
            this.GFsigma.Size = new System.Drawing.Size(49, 22);
            this.GFsigma.TabIndex = 13;
            // 
            // GaussianFilter
            // 
            this.GaussianFilter.AutoSize = true;
            this.GaussianFilter.Location = new System.Drawing.Point(389, 65);
            this.GaussianFilter.Margin = new System.Windows.Forms.Padding(4);
            this.GaussianFilter.Name = "GaussianFilter";
            this.GaussianFilter.Size = new System.Drawing.Size(125, 21);
            this.GaussianFilter.TabIndex = 18;
            this.GaussianFilter.Text = "Gaussian Filter";
            this.GaussianFilter.UseVisualStyleBackColor = true;
            // 
            // BinaryImage
            // 
            this.BinaryImage.AutoSize = true;
            this.BinaryImage.Location = new System.Drawing.Point(744, 65);
            this.BinaryImage.Margin = new System.Windows.Forms.Padding(4);
            this.BinaryImage.Name = "BinaryImage";
            this.BinaryImage.Size = new System.Drawing.Size(112, 21);
            this.BinaryImage.TabIndex = 19;
            this.BinaryImage.Text = "Binary Image";
            this.BinaryImage.UseVisualStyleBackColor = true;
            // 
            // Threshold
            // 
            this.Threshold.Location = new System.Drawing.Point(744, 95);
            this.Threshold.Margin = new System.Windows.Forms.Padding(4);
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(49, 22);
            this.Threshold.TabIndex = 20;
            // 
            // EdgeDetection
            // 
            this.EdgeDetection.AutoSize = true;
            this.EdgeDetection.Location = new System.Drawing.Point(570, 64);
            this.EdgeDetection.Margin = new System.Windows.Forms.Padding(4);
            this.EdgeDetection.Name = "EdgeDetection";
            this.EdgeDetection.Size = new System.Drawing.Size(125, 21);
            this.EdgeDetection.TabIndex = 21;
            this.EdgeDetection.Text = "Edge detection";
            this.EdgeDetection.UseVisualStyleBackColor = true;
            // 
            // BorderHandling
            // 
            this.BorderHandling.FormattingEnabled = true;
            this.BorderHandling.Items.AddRange(new object[] {
            "Empty borders",
            "Replicate rows",
            "Wrap",
            "Reflect"});
            this.BorderHandling.Location = new System.Drawing.Point(965, 88);
            this.BorderHandling.Name = "BorderHandling";
            this.BorderHandling.Size = new System.Drawing.Size(121, 24);
            this.BorderHandling.TabIndex = 22;
            this.BorderHandling.Text = "Empty borders";
            this.BorderHandling.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(985, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 15);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "Border Handling";
            // 
            // ContrastAdjustment
            // 
            this.ContrastAdjustment.AutoSize = true;
            this.ContrastAdjustment.Location = new System.Drawing.Point(184, 65);
            this.ContrastAdjustment.Margin = new System.Windows.Forms.Padding(4);
            this.ContrastAdjustment.Name = "ContrastAdjustment";
            this.ContrastAdjustment.Size = new System.Drawing.Size(156, 21);
            this.ContrastAdjustment.TabIndex = 24;
            this.ContrastAdjustment.Text = "Contrast adjustment";
            this.ContrastAdjustment.UseVisualStyleBackColor = true;
            //
            // non-linear
            //
            this.nonlinear.AutoSize = true;
            this.nonlinear.Location = new System.Drawing.Point(870, 65);
            this.nonlinear.Margin = new System.Windows.Forms.Padding(4);
            this.nonlinear.Name = "Non-linear";
            this.nonlinear.Size = new System.Drawing.Size(112, 21);
            this.nonlinear.TabIndex = 25;
            this.nonlinear.Text = "Non-linear";
            this.nonlinear.UseVisualStyleBackColor = true;
            // 
            // non-linear size
            // 
            this.NLsize.Location = new System.Drawing.Point(870, 95);
            this.NLsize.Margin = new System.Windows.Forms.Padding(4);
            this.NLsize.Name = "NLsize";
            this.NLsize.Size = new System.Drawing.Size(49, 22);
            this.NLsize.TabIndex = 26;
            // 
            // INFOIBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 760);
            this.Controls.Add(this.ContrastAdjustment);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BorderHandling);
            this.Controls.Add(this.EdgeDetection);
            this.Controls.Add(this.Threshold);
            this.Controls.Add(this.BinaryImage);
            this.Controls.Add(this.GaussianFilter);
            this.Controls.Add(this.GFsigma);
            this.Controls.Add(this.GFsize);
            this.Controls.Add(this.Grayscale);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageFileName);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.nonlinear);
            this.Controls.Add(this.NLsize);
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "INFOIBV";
            this.ShowIcon = false;
            this.Text = "INFOIBV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.TextBox imageFileName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox Grayscale;
        private System.Windows.Forms.TextBox GFsize;
        private System.Windows.Forms.TextBox GFsigma;
        private System.Windows.Forms.CheckBox GaussianFilter;
        private System.Windows.Forms.CheckBox BinaryImage;
        private System.Windows.Forms.TextBox Threshold;
        private System.Windows.Forms.CheckBox EdgeDetection;
        private System.Windows.Forms.ComboBox BorderHandling;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ContrastAdjustment;
        private System.Windows.Forms.CheckBox nonlinear;
        private System.Windows.Forms.TextBox NLsize;
    }
}

