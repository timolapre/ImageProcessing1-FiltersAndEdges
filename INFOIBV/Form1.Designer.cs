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
            this.ContrastAdjustment = new System.Windows.Forms.TrackBar();
            this.ContrastAdjustmentText = new System.Windows.Forms.TextBox();
            this.CAtext = new System.Windows.Forms.TextBox();
            this.GFsize = new System.Windows.Forms.TextBox();
            this.GFsigma = new System.Windows.Forms.TextBox();
            this.LinearFiltering = new System.Windows.Forms.TextBox();
            this.NonlinearFiltering = new System.Windows.Forms.TextBox();
            this.EdgeDetection = new System.Windows.Forms.TextBox();
            this.Thresholding = new System.Windows.Forms.TextBox();
            this.GaussianFilter = new System.Windows.Forms.CheckBox();
            this.GFtext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastAdjustment)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(17, 204);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 481);
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
            this.pictureBox2.Location = new System.Drawing.Point(637, 204);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(580, 481);
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
            // ContrastAdjustment
            // 
            this.ContrastAdjustment.Location = new System.Drawing.Point(17, 126);
            this.ContrastAdjustment.Margin = new System.Windows.Forms.Padding(4);
            this.ContrastAdjustment.Name = "ContrastAdjustment";
            this.ContrastAdjustment.Size = new System.Drawing.Size(139, 56);
            this.ContrastAdjustment.TabIndex = 8;
            this.ContrastAdjustment.Scroll += new System.EventHandler(this.ContrastAdjustment_Scroll);
            // 
            // ContrastAdjustmentText
            // 
            this.ContrastAdjustmentText.BackColor = System.Drawing.SystemColors.Menu;
            this.ContrastAdjustmentText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContrastAdjustmentText.Location = new System.Drawing.Point(17, 102);
            this.ContrastAdjustmentText.Margin = new System.Windows.Forms.Padding(4);
            this.ContrastAdjustmentText.Name = "ContrastAdjustmentText";
            this.ContrastAdjustmentText.Size = new System.Drawing.Size(133, 15);
            this.ContrastAdjustmentText.TabIndex = 9;
            this.ContrastAdjustmentText.Text = "Contrast Adjustment";
            // 
            // CAtext
            // 
            this.CAtext.Location = new System.Drawing.Point(28, 174);
            this.CAtext.Margin = new System.Windows.Forms.Padding(4);
            this.CAtext.Name = "CAtext";
            this.CAtext.Size = new System.Drawing.Size(119, 22);
            this.CAtext.TabIndex = 10;
            // 
            // GFsize
            // 
            this.GFsize.Location = new System.Drawing.Point(226, 95);
            this.GFsize.Margin = new System.Windows.Forms.Padding(4);
            this.GFsize.Name = "GFsize";
            this.GFsize.Size = new System.Drawing.Size(49, 22);
            this.GFsize.TabIndex = 12;
            // 
            // GFsigma
            // 
            this.GFsigma.Location = new System.Drawing.Point(283, 95);
            this.GFsigma.Margin = new System.Windows.Forms.Padding(4);
            this.GFsigma.Name = "GFsigma";
            this.GFsigma.Size = new System.Drawing.Size(49, 22);
            this.GFsigma.TabIndex = 13;
            // 
            // LinearFiltering
            // 
            this.LinearFiltering.BackColor = System.Drawing.SystemColors.Menu;
            this.LinearFiltering.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinearFiltering.Location = new System.Drawing.Point(416, 65);
            this.LinearFiltering.Margin = new System.Windows.Forms.Padding(4);
            this.LinearFiltering.Name = "LinearFiltering";
            this.LinearFiltering.Size = new System.Drawing.Size(133, 15);
            this.LinearFiltering.TabIndex = 14;
            this.LinearFiltering.Text = "Linear Filtering";
            // 
            // NonlinearFiltering
            // 
            this.NonlinearFiltering.BackColor = System.Drawing.SystemColors.Menu;
            this.NonlinearFiltering.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NonlinearFiltering.Location = new System.Drawing.Point(580, 66);
            this.NonlinearFiltering.Margin = new System.Windows.Forms.Padding(4);
            this.NonlinearFiltering.Name = "NonlinearFiltering";
            this.NonlinearFiltering.Size = new System.Drawing.Size(133, 15);
            this.NonlinearFiltering.TabIndex = 15;
            this.NonlinearFiltering.Text = "Nonlinear Filtering";
            // 
            // EdgeDetection
            // 
            this.EdgeDetection.BackColor = System.Drawing.SystemColors.Menu;
            this.EdgeDetection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EdgeDetection.Location = new System.Drawing.Point(748, 65);
            this.EdgeDetection.Margin = new System.Windows.Forms.Padding(4);
            this.EdgeDetection.Name = "EdgeDetection";
            this.EdgeDetection.Size = new System.Drawing.Size(133, 15);
            this.EdgeDetection.TabIndex = 16;
            this.EdgeDetection.Text = "Edge Detection";
            // 
            // Thresholding
            // 
            this.Thresholding.BackColor = System.Drawing.SystemColors.Menu;
            this.Thresholding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Thresholding.Location = new System.Drawing.Point(948, 65);
            this.Thresholding.Margin = new System.Windows.Forms.Padding(4);
            this.Thresholding.Name = "Thresholding";
            this.Thresholding.Size = new System.Drawing.Size(133, 15);
            this.Thresholding.TabIndex = 17;
            this.Thresholding.Text = "Thresholding";
            // 
            // GaussianFilter
            // 
            this.GaussianFilter.AutoSize = true;
            this.GaussianFilter.Location = new System.Drawing.Point(226, 64);
            this.GaussianFilter.Margin = new System.Windows.Forms.Padding(4);
            this.GaussianFilter.Name = "GaussianFilter";
            this.GaussianFilter.Size = new System.Drawing.Size(125, 21);
            this.GaussianFilter.TabIndex = 18;
            this.GaussianFilter.Text = "Gaussian Filter";
            this.GaussianFilter.UseVisualStyleBackColor = true;
            // 
            // GFtext
            // 
            this.GFtext.Location = new System.Drawing.Point(1224, 204);
            this.GFtext.Multiline = true;
            this.GFtext.Name = "GFtext";
            this.GFtext.Size = new System.Drawing.Size(176, 173);
            this.GFtext.TabIndex = 19;
            // 
            // INFOIBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 709);
            this.Controls.Add(this.GFtext);
            this.Controls.Add(this.GaussianFilter);
            this.Controls.Add(this.Thresholding);
            this.Controls.Add(this.EdgeDetection);
            this.Controls.Add(this.NonlinearFiltering);
            this.Controls.Add(this.LinearFiltering);
            this.Controls.Add(this.GFsigma);
            this.Controls.Add(this.GFsize);
            this.Controls.Add(this.CAtext);
            this.Controls.Add(this.ContrastAdjustmentText);
            this.Controls.Add(this.ContrastAdjustment);
            this.Controls.Add(this.Grayscale);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageFileName);
            this.Controls.Add(this.LoadImageButton);
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "INFOIBV";
            this.ShowIcon = false;
            this.Text = "INFOIBV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastAdjustment)).EndInit();
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
        private System.Windows.Forms.TrackBar ContrastAdjustment;
        private System.Windows.Forms.TextBox ContrastAdjustmentText;
        private System.Windows.Forms.TextBox CAtext;
        private System.Windows.Forms.TextBox GFsize;
        private System.Windows.Forms.TextBox GFsigma;
        private System.Windows.Forms.TextBox LinearFiltering;
        private System.Windows.Forms.TextBox NonlinearFiltering;
        private System.Windows.Forms.TextBox EdgeDetection;
        private System.Windows.Forms.TextBox Thresholding;
        private System.Windows.Forms.CheckBox GaussianFilter;
        private System.Windows.Forms.TextBox GFtext;
    }
}

