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
        int apert = 2;
        double sigma = 0.3;

        double[] kernelGauss;

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

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            LoadMini();
            CountSigma();

            if (tabControl.SelectedIndex == 1)
            {
                FilterGauss();
                FilterMedian();
            }
        }

        private void CountSigma()
        {
            sigma = Math.Round((double)apert / 3, 1);
            CountKernelGauss();
        }

        private void CountKernelGauss()
        {
            int n = 2 * apert + 1;

            double[] kernel = new double[Convert.ToInt16(Math.Pow(n, 2))];

            for (int i = -apert; i < apert + 1; i++)
            {
                for (int j = -apert; j < apert + 1; j++) 
                {
                    kernel[(i + apert) * n + j + apert] = Math.Exp(-(i * i + j * j) / (2 * sigma * sigma)) / (2 * sigma * sigma * Math.PI);
                }
            }

            kernelGauss = kernel;
        }

        private Bitmap MakeImgWithBordersCopy()
        {
            Bitmap imgStart = new Bitmap(pictureBoxNoise.Image);

            Bitmap img = new Bitmap(imgStart.Width + apert * 2, imgStart.Height + apert * 2);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    int x, y;

                    if (i < apert)
                    {
                        x = 0;
                    }
                    else if (i >= apert + imgStart.Width)
                    {
                        x = imgStart.Width - 1;
                    }
                    else
                    {
                        x = i - apert;
                    }

                    if (j < apert)
                    {
                        y = 0;
                    }
                    else if (j >= apert + imgStart.Height)
                    {
                        y = imgStart.Height - 1;
                    }
                    else
                    {
                        y = j - apert;
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

            progressBar1.Visible = true;
            progressBar1.Maximum = img.Width * img.Height;
            progressBar1.Value = 0;

            int n = apert * 2 + 1;

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

                    progressBar1.Value += 1;
                }
            }

            progressBar1.Visible = false;

            pictureBoxGauss.Image = img;
        }


        private int Partition(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    (array[pivot], array[i]) = (array[i], array[pivot]);
                }
            }

            pivot++;

            (array[pivot], array[maxIndex]) = (array[maxIndex], array[pivot]);

            return pivot;
        }

        private int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int index = Partition(array, minIndex, maxIndex);

            QuickSort(array, minIndex, index - 1);
            QuickSort(array, index + 1, maxIndex);

            return array;
        }

        private int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        private void FilterMedian()
        {
            Bitmap imgNoise = MakeImgWithBordersCopy();
            Bitmap img = new Bitmap(pictureBoxNoise.Image);

            progressBar1.Visible = true;
            progressBar1.Maximum = img.Width * img.Height;
            progressBar1.Value = 0;

            int n = apert * 2 + 1;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    int[] rmas = new int[n * n];
                    int[] gmas = new int[n * n];
                    int[] bmas = new int[n * n];

                    for (int k = 0; k < n; k++)
                    {
                        for (int l = 0; l < n; l++)
                        {
                            Color pixel = imgNoise.GetPixel(i + l, j + k);

                            rmas[k * n + l] = pixel.R;
                            gmas[k * n + l] = pixel.G;
                            bmas[k * n + l] = pixel.B;
                        }
                    }

                    img.SetPixel(i, j, Color.FromArgb(img.GetPixel(i, j).A, QuickSort(rmas)[apert], QuickSort(gmas)[apert], QuickSort(bmas)[apert]));

                    progressBar1.Value += 1;
                }
            }

            progressBar1.Visible = false;

            pictureBoxMedian.Image = img;
        }

        private void TrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            apert = trackBar1.Value;

            CountSigma();

            FilterGauss();
            FilterMedian();
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
