﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace INFOIBV
{
    public partial class INFOIBV : Form
    {
        private Bitmap InputImage;
        private Bitmap OutputImage;

        float sigma;
        int size;
        float[,] Gaussiankernel;
        int[,] ImageWithGaussianFilter;

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

            //GaussianFilter
            if (GaussianFilter.Checked)
            {
                sigma = float.Parse(this.GFsigma.Text);
                size = int.Parse(this.GFsize.Text); // minimum size: 1
                Gaussiankernel = GaussianKernel(size, sigma);
                ImageWithGaussianFilter = new int[InputImage.Size.Width, InputImage.Size.Height];
            }

            // Run filters
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = Image[x, y];                         // Get the pixel color at coordinate (x,y)
                    Color updatedColor = pixelColor;

                    //Grayscale
                    if (Grayscale.Checked)
                    {
                        int grayscale = toGrayscale(pixelColor);
                        updatedColor = Color.FromArgb(grayscale, grayscale, grayscale); //Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B); // Negative image
                    }

                    //Contrast adjustment
                    float ContrastCorrection = ContrastAdjustment.Value; //(259f * (ContrastAdjustment.Value + 255f)) / (255f*(259f - ContrastAdjustment.Value));
                    int red = truncate((int)(ContrastCorrection * (updatedColor.R - 128) + 128));
                    int green = truncate((int)(ContrastCorrection * (updatedColor.G - 128) + 128));
                    int blue = truncate((int)(ContrastCorrection * (updatedColor.B - 128) + 128));
                    updatedColor = Color.FromArgb(red, green, blue);

                    if (BinaryImage.Checked)
                    {
                        //Debug.WriteLine(toGrayscale(pixelColor) + " " + int.Parse(Threshold.Text));
                        if(toGrayscale(pixelColor) > int.Parse(Threshold.Text))
                        {
                            updatedColor = Color.FromArgb(255, 255, 255);
                        }
                        else
                        {
                            updatedColor = Color.FromArgb(0, 0, 0);
                        }
                    }

                    Image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)

                    //GaussianFilter
                    if (GaussianFilter.Checked)
                    {
                        float value = 0;
                        for (int n = -size; n < size; n++)
                        {
                            for (int m = -size; m < size; m++)
                            {
                                //Debug.Write(Gaussiankernel[n+size, m + size] + " " + toGrayscale(Image[truncate(x + n), truncate(y + m)]) + " ");
                                if (x + n >= InputImage.Size.Width || x + n < 0 || y + m >= InputImage.Size.Height || y + m < 0)
                                    continue;
                                value += Gaussiankernel[n+size, m+size] * toGrayscale(Image[x + n, y + m]);
                            }
                        }
                        //Debug.WriteLine(value);
                        ImageWithGaussianFilter[x, y] = (int)value;
                    }

                    progressBar.PerformStep();                              // Increment progress bar
                }
            }

            //Gaussian Filter
            if (GaussianFilter.Checked)
            {
                for (int x = 0; x < InputImage.Size.Width; x++)
                {
                    for (int y = 0; y < InputImage.Size.Height; y++)
                    {
                        ImageWithGaussianFilter[x, y] = truncate(ImageWithGaussianFilter[x, y]);
                        Color updatedColor = Color.FromArgb(ImageWithGaussianFilter[x, y], ImageWithGaussianFilter[x, y], ImageWithGaussianFilter[x, y]);
                        Image[x, y] = updatedColor;
                    }
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

        private int toGrayscale(Color pixelColor)
        {
            int grayscale = (int)((pixelColor.R * 0.3f) + (pixelColor.G * 0.59f) + (pixelColor.B * 0.11f));
            return grayscale;
        }

        private int truncate(int value)
        {
            return Math.Max(Math.Min(value, 255),0);
        }

        private float [,] GaussianKernel(int size, float sigma)
        {
            float total = 0;
            float isit1 = 0;
            float[,] kernel = new float[size*2+1, size*2+1];
            for (int x = -size; x <= size; x++)
            {
                for (int y = -size; y <= size; y++)
                {
                    kernel[x + size, y + size] = (float)((1 / (2 * Math.PI * Math.Pow(sigma,2))) * Math.Pow(Math.E, -((Math.Pow(x, 2) + Math.Pow(y, 2)) / ( 2 * Math.Pow(sigma, 2)))));
                    total += kernel[x + size, y + size];
                }
            }
            for (int x = -size; x <= size; x++)
            {
                for (int y = -size; y <= size; y++)
                {
                    kernel[x + size, y + size] = (1/total)*kernel[x + size, y + size];
                    Debug.Write(kernel[x + size, y + size] + " ");
                    isit1 += kernel[x + size, y + size];
                }
                Debug.WriteLine("");
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
