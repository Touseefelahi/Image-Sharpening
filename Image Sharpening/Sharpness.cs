using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Image_Sharpening
{
    public partial class Sharpness : Form
    {
        Image<Gray, byte> imageOriginal;
        Image<Gray, byte> imageConverted=new Image<Gray, byte>(640,480);
        Image<Gray, byte> imageDifference;
        Image<Gray, byte> imageZoomed;

        float sharpFactor = 0f;
        int blurFactor = 7;
        byte threshold = 100;
        int firstPixRow = 0, firstPixCol = 0;
        int zoomFactor = 4;
        string imagePath = "C:\\Users\\touseef.elahi\\Documents\\Visual Studio 2015\\Projects\\Image Sharpening\\Image Sharpening\\blur2.png";

        public Sharpness()
        {
            InitializeComponent();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            DialogResult path = openFileDialog.ShowDialog();
            if (path == DialogResult.OK)
            {
                try
                {
                    imagePath = openFileDialog.FileName;
                    imageOriginal = new Image<Gray, byte>(imagePath);
                    imageBoxOriginal.Image = imageOriginal;
                    buttonRefresh.Enabled = true;
                }
                catch (Exception)
                {
                    textBoxErrors.AppendText("Error Opening image file, make sure that you selected an correct image file\n"); 
                }
                //Zooming
                zoomImage();
            }
        }
        private void zoomImage()
        {
            int rowZ = 0, colZ = 0;
            try
            {
                imageZoomed = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);
                firstPixCol = Convert.ToUInt16(textBoxFirstCol.Text);
                firstPixRow = Convert.ToUInt16(textBoxFirstRow.Text);
                if (zoomFactor == 1) firstPixCol = firstPixRow = 0;

                int maxRow = firstPixRow + imageOriginal.Rows / zoomFactor ;
                int maxCol = firstPixCol + imageOriginal.Cols / zoomFactor ;

                for (int row = firstPixRow; row < maxRow; row++)
                {
                    for (int col = firstPixCol; col < maxCol; col++)
                    {
                        int pixel = 0;
                        pixel = (int)(imageOriginal.Data[row, col, 0]);
                        for (int rowm = 0; rowm < zoomFactor; rowm++)
                        {
                            for (int colm = 0; colm < zoomFactor; colm++)
                            {                         
                                imageZoomed.Data[rowZ + rowm, colZ + colm, 0] = (byte)pixel;
                            }                       
                        }
                        colZ+=zoomFactor;
                    }
                    colZ = 0;
                    rowZ += zoomFactor;
                }//zooming done
                imageBox2.Image = imageZoomed;
            }
            catch (Exception ex)
            {
                textBoxErrors.AppendText("Select Proper values for starting row and column(" +
                    Convert.ToString(rowZ) + "," + Convert.ToString(colZ) + ")\n" + Convert.ToString(ex));
            }
        }

        private void buttonSharp_Click(object sender, EventArgs e)
        {
            if (imageConverted.Data == null)
            {
                imageConverted = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);
            }
            float[,] sharpMask = new float[,]
                {   {0,             -sharpFactor,       0},
                    {-sharpFactor,  1+4*sharpFactor,    -sharpFactor },
                    {0,             -sharpFactor,       0 }
                };


            for (int row = 1; row < imageOriginal.Rows-1; row++)
            {
                for (int col = 1; col < imageOriginal.Cols-1; col++)
                {
                    //for sharpening Mask 3x3
                    int pixelConverted = 0;
                    for (int rowm = 0; rowm <3; rowm++)
                    {
                        for (int colm = 0; colm < 3; colm++)
                        {
                            pixelConverted += (int)(imageZoomed.Data[row-1+rowm, col-1+colm, 0] * sharpMask[rowm,colm]);
                          //  pixelConverted += (int)(imageOriginal.Data[row - 1 + rowm, col - 1 + colm, 0] *(1/sharpFactor));
                        }
                    }
                    if (pixelConverted > 255) pixelConverted = 255;
                    else if (pixelConverted < 0) pixelConverted = 0;
                    
                    imageConverted.Data[row, col, 0] = (byte)pixelConverted;
                }
            }//Sharpening Done

           
            imageBoxShapen.Image = imageConverted;
            textBoxErrors.AppendText("Sharpening Done at factor "+Convert.ToString(sharpFactor)+"\n");
            textBoxSharpFactor.Text = Convert.ToString(sharpFactor);

            try
            {
                var imageConverted2 = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);
                CvInvoke.Add(imageConverted, imageDifference, imageConverted2, null, DepthType.Default);
                imageBox2.Image = imageConverted2;
            }
            catch (Exception) {}

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sharpFactor = trackBar1.Value / 100f;
            buttonRefresh.PerformClick();
        }

        private void textBoxSharpFactor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    sharpFactor = (float)(Convert.ToDouble(textBoxSharpFactor.Text));
                }
                catch (Exception)  { }
                buttonRefresh.PerformClick();
            }
        }

        private void buttonBlur_Click(object sender, EventArgs e)
        {
            imageConverted = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);
         
            if (blurFactor == 0)
            {
                blurFactor = 1;
            }

           
            for (int row = 1; row < imageOriginal.Rows - 1; row++)
            {
                for (int col = 1; col < imageOriginal.Cols - 1; col++)
                {
                    //for blurring Mask 3x3
                    int pixelConverted = 0;
                    for (int rowm = 0; rowm < 3; rowm++)
                    {
                        for (int colm = 0; colm < 3; colm++)
                        {
                            pixelConverted += (int)(imageZoomed.Data[row - 1 + rowm, col - 1 + colm, 0] * (1.0 / blurFactor));
                        }
                    }
                    if (pixelConverted > 255) pixelConverted = 255;
                    else if (pixelConverted < 0) pixelConverted = 0;
                    imageConverted.Data[row, col, 0] = (byte)pixelConverted;
                }
            }//Sharpening Done
            imageBoxShapen.Image = imageConverted;
            textBoxErrors.AppendText("Blurring Done at factor " + Convert.ToString(blurFactor) + "\n");
            textBoxBlurfactor.Text = Convert.ToString(blurFactor);
        }

        private void buttonBlur_Click1(object sender, EventArgs e)
        {
            if (imageConverted.Data == null)
            {
                imageConverted = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);
            }

            if (blurFactor == 0)
            {
                blurFactor = 1;
            }

            float[,] sharpMask = new float[,]
              {   {-1,             -sharpFactor,       -1},
                    {-sharpFactor,  1+4*sharpFactor,    -sharpFactor },
                    {-1,             -sharpFactor,       -1 }
              };

            var r=10;
            int rs =(int)Math.Ceiling(r * 2.57);
            var w = imageOriginal.Cols;
            var h = imageOriginal.Rows;
            for (int row = 0; row < imageOriginal.Rows; row++)
            {
                for (int col = 0; col < imageOriginal.Cols; col++)
                {
                    //Applying blur
                    double val = 0, wsum = 0;
                    for(var rowm = row - rs; rowm < row + rs + 1; rowm++)
                    {
                        for (int colm = col - rs; colm < col + rs + 1; colm++)
                        {
                            var x = Math.Min(w - 1, Math.Max(0, colm));
                            var y = Math.Min(h - 1, Math.Max(0, rowm));
                            var dsq = (colm - col) * (colm - col) + (rowm - row) * (rowm - row);
                            var wght = Math.Exp(-dsq / (2 * r * r)) / (Math.PI * 2 * r * r);
                            val += imageOriginal.Data[row,col,0] * wght;
                            wsum += wght;
                        }
                    }
                    imageConverted.Data[row, col, 0] =(byte) Math.Round(val / wsum);
                }
            }//Sharpening Done
            imageBoxShapen.Image = imageConverted;
            textBoxErrors.AppendText("Blurring Done at factor " + Convert.ToString(blurFactor) + "\n");
            textBoxBlurfactor.Text = Convert.ToString(blurFactor);
        }

        private void trackBarBlurfactor_Scroll(object sender, EventArgs e)
        {
            blurFactor = trackBarBlurfactor.Value;
            buttonBlur1.PerformClick();
        }

        private void buttonDifference_Click(object sender, EventArgs e)
        {
            if (imageConverted.Data != null)
            {
                imageDifference = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);
                CvInvoke.AbsDiff(imageZoomed, imageConverted, imageDifference);
                imageBox2.Image = imageDifference;
            }
        }

        private void buttonBlurOpenCV_Click(object sender, EventArgs e)
        {
            if (blurFactor < 3) blurFactor = 3;
            CvInvoke.Blur(imageOriginal, imageConverted, new Size(blurFactor,blurFactor),new Point(0,0),BorderType.Default );
            imageBoxShapen.Image = imageConverted;
        }

        private void buttonAverageBlur_Click(object sender, EventArgs e)
        {
            try
            {
                int divisor =Convert.ToInt16( textBoxDivisor.Text);
                double[,] kernel = new double[,]
          {
                {16 ,8 ,16},
                { 8, 4,8},
                { 16,8 ,16}
          };

                kernel[0, 0] = Convert.ToDouble(textBox00.Text);
                kernel[0, 1] = Convert.ToDouble(textBox01.Text);
                kernel[0, 2] = Convert.ToDouble(textBox02.Text);
                kernel[1, 0] = Convert.ToDouble(textBox10.Text);
                kernel[1, 1] = Convert.ToDouble(textBox11.Text);
                kernel[1, 2] = Convert.ToDouble(textBox12.Text);
                kernel[2, 0] = Convert.ToDouble(textBox20.Text);
                kernel[2, 1] = Convert.ToDouble(textBox21.Text);
                kernel[2, 2] = Convert.ToDouble(textBox22.Text);


                imageConverted = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);
                var imageCopy = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);
                imageDifference = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);

                
                imageZoomed.CopyTo(imageCopy);

                var iteration = Convert.ToInt16(textBoxIterations.Text);
                while (iteration > 0)
                {
                    for (int row = 1; row < imageCopy.Rows - 1; row++)
                    {
                        for (int col = 1; col < imageCopy.Cols - 1; col++)
                        {
                            //for blurring Mask 3x3

                            byte currentPixel = imageCopy.Data[row, col, 0];
                            int pixelConverted = (int)(currentPixel * kernel[1, 1]);
                            pixelConverted += (int)(imageCopy.Data[row + 1, col, 0] * kernel[2, 1]);
                            pixelConverted += (int)(imageCopy.Data[row - 1, col, 0] * kernel[0, 1]);
                            pixelConverted += (int)(imageCopy.Data[row, col + 1, 0] * kernel[1, 2]);
                            pixelConverted += (int)(imageCopy.Data[row, col - 1, 0] * kernel[1, 0]);
                            pixelConverted += (int)(imageCopy.Data[row + 1, col + 1, 0] * kernel[2, 2]);
                            pixelConverted += (int)(imageCopy.Data[row - 1, col - 1, 0] * kernel[0, 0]);
                            pixelConverted += (int)(imageCopy.Data[row - 1, col + 1, 0] * kernel[0, 2]);
                            pixelConverted += (int)(imageCopy.Data[row + 1, col - 1, 0] * kernel[2, 0]);
                            pixelConverted = pixelConverted / divisor;

                            if (checkBoxBinaryImage.Checked)
                                imageConverted.Data[row, col, 0] = (byte)(pixelConverted>threshold?255:0);
                            else
                            {
                                if (pixelConverted > 255) pixelConverted = 255;
                                else if (pixelConverted < 0) pixelConverted = 0;
                                imageConverted.Data[row, col, 0] = (byte)(pixelConverted);
                            }
                               
                        }
                    }
                    imageConverted.CopyTo(imageDifference);
                    imageConverted.CopyTo(imageCopy);
                    iteration--;
                }

                imageBoxShapen.Image = imageConverted;
            }
            catch (Exception ex)
            {
                textBoxErrors.AppendText("Error"+Convert.ToString(ex));
            }
          
                  
        }

        private void buttonBlur2_Click(object sender, EventArgs e)
        {
            double pixel;
            int gaussW = 7;                            // Level(+1)
            int[] mask = { 1, 6, 15, 20, 15, 6, 1 }; // Mask
            int gaussSum = 64;
            var imageTmp = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);

            for (int row = gaussW-1; row < imageOriginal.Rows - 1; row++)
            {
                for (int col = 1; col < imageOriginal.Cols - 1; col++)
                {
                    pixel = 0;
                    for (int k = 0; k < gaussW; k++)
                    {
                        pixel += imageOriginal.Data[row - (gaussW - 1) + k, col, 0]*mask[k];
                    }
                    pixel = pixel / gaussSum;

                    imageTmp.Data[row, col, 0] = (byte)pixel;
                }
            }//Sharpening Done

        }

        private void buttonContrastAdjustment_Click(object sender, EventArgs e)
        {
            double multiplier =Convert.ToDouble(textBoxMultiplier.Text);
            int threshold = Convert.ToInt16(textBoxThreshold.Text);

            for (int row = 0; row < imageOriginal.Rows - 1; row++)
            {
                for (int col = 0; col < imageOriginal.Cols - 1; col++)
                {
                    int pixel = imageOriginal.Data[row, col, 0];

                    pixel =(int) ((pixel - threshold) * multiplier);
                    pixel += threshold;
                    if (pixel < 0) pixel = 0;
                    else if (pixel > 255) pixel = 255;

                    imageOriginal.Data[row, col, 0]=(byte)pixel;
                }
            }
            imageBoxOriginal.Image = imageOriginal;
        }

        private void buttonResetImage_Click(object sender, EventArgs e)
        {
            imageOriginal = new Image<Gray, byte>(imagePath);
            imageBoxOriginal.Image = imageOriginal;
        }

        private void buttonSharpContrast_Click(object sender, EventArgs e)
        {
            double multiplier = Convert.ToDouble(textBoxMultiplier.Text);
            int threshold = Convert.ToInt16(textBoxThreshold.Text);
            var imageConvertedCopy = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);

            for (int row = 0; row < imageOriginal.Rows - 1; row++)
            {
                for (int col = 0; col < imageOriginal.Cols - 1; col++)
                {
                    int pixel = imageConverted.Data[row, col, 0];

                    pixel = (int)((pixel - threshold) * multiplier);
                    pixel += threshold;
                    if (pixel < 0) pixel = 0;
                    else if (pixel > 255) pixel = 255;

                    imageConvertedCopy.Data[row, col, 0] = (byte)pixel;
                }
            }
            imageBoxShapen.Image = imageConvertedCopy;

            var imageConverted2 = new Image<Gray, byte>(imageOriginal.Cols, imageOriginal.Rows);
            CvInvoke.Add(imageConvertedCopy, imageDifference, imageConverted2, null, DepthType.Default);
            imageBox2.Image = imageConverted2;
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            var path2=imagePath;
            path2 += textBoxFileName.Text + ".jpg";
            CvInvoke.Imwrite(path2, imageConverted);
        }
       
        private void trackBarThreshold_Scroll(object sender, EventArgs e)
        {
            threshold =(byte)trackBarThreshold.Value;
            textBoxThreshold1.Text = Convert.ToString(threshold);
            buttonAverageBlur.PerformClick();

        }

        private void comboBoxZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoomFactor = Convert.ToInt16(comboBoxZoom.Text);
            zoomImage();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            threshold = Convert.ToByte(textBoxThreshold1.Text);

        }
    }
}
