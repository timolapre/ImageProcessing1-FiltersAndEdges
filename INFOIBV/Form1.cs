using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace INFOIBV
{
    public partial class INFOIBV : Form
    {
        private Bitmap InputImage;
        private Bitmap OutputImage;

        public INFOIBV()
        {
            InitializeComponent();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
           if (openImageDialog.ShowDialog() == DialogResult.OK)             // Open File Dialog
            {
                string file = openImageDialog.FileName;                     // Get the file name
                imageFileName.Text = file;                                  // Show file name
                if (InputImage != null) InputImage.Dispose();               // Reset image
                InputImage = new Bitmap(file);                              // Create new Bitmap from file
                if (InputImage.Size.Height <= 0 || InputImage.Size.Width <= 0 ||
                    InputImage.Size.Height > 512 || InputImage.Size.Width > 512) // Dimension check
                    MessageBox.Show("Error in image dimensions (have to be > 0 and <= 512)");
                else
                    pictureBox1.Image = (Image) InputImage;                 // Display input image
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (InputImage == null) return;                                 // Get out if no input image
            if (OutputImage != null) OutputImage.Dispose();                 // Reset output image
            OutputImage = new Bitmap(InputImage.Size.Width, InputImage.Size.Height); // Create new output image
            Color[,] Image = new Color[InputImage.Size.Width, InputImage.Size.Height]; // Create array to speed-up operations (Bitmap functions are very slow)

            // Setup progress bar
            progressBar.Visible = true;
            progressBar.Minimum = 1;
            progressBar.Maximum = InputImage.Size.Width * InputImage.Size.Height;
            progressBar.Value = 1;
            progressBar.Step = 1;

            // Copy input Bitmap to array            
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Image[x, y] = InputImage.GetPixel(x, y);                // Set pixel color in array at (x,y)
                }
            }

            //==========================================================================================
            // TODO: include here your own code

            // example: create a negative image
            GFtext.Text = "";
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = Image[x, y];                         // Get the pixel color at coordinate (x,y)
                    Color updatedColor = pixelColor;

                    //Grayscale
                    if (Grayscale.Checked)
                    {
                        int grayscale = (int)((pixelColor.R * 0.3f) + (pixelColor.G * 0.59f) + (pixelColor.B * 0.11f));
                        updatedColor = Color.FromArgb(grayscale, grayscale, grayscale); //Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B); // Negative image
                    }

                    //Contrast adjustment
                    float ContrastCorrection = ContrastAdjustment.Value; //(259f * (ContrastAdjustment.Value + 255f)) / (255f*(259f - ContrastAdjustment.Value));
                    int red = truncate((int)(ContrastCorrection * (updatedColor.R - 128) + 128));
                    int green = truncate((int)(ContrastCorrection * (updatedColor.G - 128) + 128));
                    int blue = truncate((int)(ContrastCorrection * (updatedColor.B - 128) + 128));
                    updatedColor = Color.FromArgb(red, green, blue);

                    //GaussianFilter
                    if (GaussianFilter.Checked)
                    {
                        GFtext.Text = "a";
                        int sigma = int.Parse(GFsigma.Text);
                        int size = int.Parse(GFsize.Text); // minimum size: 3
                        int[,] Gaussiankernel = GaussianKernel(size, sigma);
                    }

                    Image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }
            }
            //==========================================================================================

            // Copy array to output Bitmap
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    OutputImage.SetPixel(x, y, Image[x, y]);               // Set the pixel color at coordinate (x,y)
                }
            }
            
            pictureBox2.Image = (Image)OutputImage;                         // Display output image
            progressBar.Visible = false;                                    // Hide progress bar
        }

        private int truncate(int value)
        {
            return Math.Max(Math.Min(value, 255),0);
        }

        private int [,] GaussianKernel(int size, int sigma)
        {
            int[,] kernel = new int[size, size];
            int offset = (size - 1) / 2;
            for (int x = -offset; x <= offset; x++)
            {
                for (int y = -offset; y <= offset; y++)
                {
                    kernel[x + offset,y + offset] = (int)((1 / 2 * Math.PI * sigma) * Math.Pow(Math.E, -(Math.Pow(x, 2) + Math.Pow(y, 2) / 2 * Math.Pow(sigma, 2))));
                }
            }
            return kernel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (OutputImage == null) return;                                // Get out if no output image
            if (saveImageDialog.ShowDialog() == DialogResult.OK)
                OutputImage.Save(saveImageDialog.FileName);                 // Save the output image
        }

        private void ContrastAdjustment_Scroll(object sender, EventArgs e)
        {
            float ContrastCorrection = (259f * (ContrastAdjustment.Value + 255f)) / (255f * (259f - ContrastAdjustment.Value));
            CAtext.Text = ContrastAdjustment.Value + " " + ContrastCorrection;
        }
    }
}
