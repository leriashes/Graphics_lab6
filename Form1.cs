using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_lab6
{
    public partial class MainForm : Form
    {
        int appert = 8;
        double sigma = 0.3;

        double[] kernelGauss;
        double[] kernelMedian;

        public MainForm()
        {
            InitializeComponent();
            MakeNoise();
        }

        private void LoadImage(string fileName)
        {
            pictureBoxStart.Image = new Bitmap(fileName);
            MakeNoise();
            LoadMini();
        }

        private void LoadMini() 
        {
            if (tabControl.SelectedIndex == 1)
            {
                pictureBoxStartMini.Image = pictureBoxStart.Image;
                pictureBoxNoiseMini.Image = pictureBoxNoise.Image;
            }
        }

        private void MakeNoise()
        {
            Bitmap img = new Bitmap(pictureBoxStart.Image);

            Random rand = new Random();

            double prob = 0.2;
            int val = 40;
            int count = 0;


            for (int x = 0; x < img.Width; x++) 
            {
                for (int y = 0; y < img.Height; y++)
                {
                    if (rand.NextDouble() < prob)
                    {
                        Color pixel = img.GetPixel(x, y);

                        int R, G, B;
                        int value = rand.Next(-val, val + 1);

                        R = pixel.R + value;
                        G = pixel.G + value;
                        B = pixel.B + value;

                        img.SetPixel(x, y, Color.FromArgb(pixel.A, NormalizeColor(R), NormalizeColor(G), NormalizeColor(B)));

                        count += 1;
                    }
                }
            }

            pictureBoxNoise.Image = img;        
        }

        private int NormalizeColor(int color)
        {
            if (color < 0)
            {
                color = 0;
            }
            else if (color > 255)
            {
                color = 255;
            }

            return color;
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadImage(openFileDialog.FileName);
            }
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LoadMini();
            CountSigma();

            FilterGauss();
        }

        private void CountSigma()
        {
            sigma = Math.Round((double)appert / 3, 1);
            CountKernelGauss();
        }

        private void CountKernelGauss()
        {
            int n = 2 * appert + 1;

            double[] kernel = new double[Convert.ToInt16(Math.Pow(n, 2))];

            for (int i = -appert; i < appert + 1; i++)
            {
                for (int j = -appert; j < appert + 1; j++) 
                {
                    kernel[(i + appert) * n + j + appert] = Math.Exp(-(i * i + j * j) / (2 * sigma * sigma)) / (2 * sigma * sigma * Math.PI);
                }
            }

            kernelGauss = kernel;
        }

        private Bitmap MakeImgWithBordersCopy()
        {
            Bitmap imgStart = new Bitmap(pictureBoxNoise.Image);

            Bitmap img = new Bitmap(imgStart.Width + appert * 2, imgStart.Height + appert * 2);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    int x, y;

                    if (i < appert)
                    {
                        x = 0;
                    }
                    else if (i >= appert + imgStart.Width)
                    {
                        x = imgStart.Width - 1;
                    }
                    else
                    {
                        x = i - appert;
                    }

                    if (j < appert)
                    {
                        y = 0;
                    }
                    else if (j >= appert + imgStart.Height)
                    {
                        y = imgStart.Height - 1;
                    }
                    else
                    {
                        y = j - appert;
                    }

                    img.SetPixel(i, j, imgStart.GetPixel(x, y));
                }
            }

            return img;
        }

        private void FilterGauss()
        {
            Bitmap imgNoise = MakeImgWithBordersCopy();
            Bitmap img = new Bitmap(pictureBoxNoise.Image);

            int n = appert * 2 + 1;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    double R = 0;
                    double G = 0;
                    double B = 0;

                    for (int k = 0; k < n; k++)
                    {
                        for(int l = 0; l < n; l++) 
                        {
                            Color pixel = imgNoise.GetPixel(i + l, j + k);

                            R += pixel.R * kernelGauss[k * n + l];
                            G += pixel.G * kernelGauss[k * n + l];
                            B += pixel.B * kernelGauss[k * n + l];
                        }
                    }

                    img.SetPixel(i, j, Color.FromArgb(img.GetPixel(i, j).A, NormalizeColor(Convert.ToInt32(Math.Round(R))), NormalizeColor(Convert.ToInt32(Math.Round(G))), NormalizeColor(Convert.ToInt32(Math.Round(B)))));
                }
            }

            pictureBoxGauss.Image = img;
        }
    }
}
