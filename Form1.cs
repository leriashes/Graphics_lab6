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
        int apertSharp = 1;
        double kSharp = 2;
        double sigma = 0.3;
        int alpha = 100;
        bool whiteBackground = false;
        bool algorithmSobel = true;

        bool[] counted = new bool[3];

        double[] kernelGauss;

        public MainForm()
        {
            InitializeComponent();
            pictureBoxStartSharp.Image = new Bitmap(pictureBoxStart.Image);
            pictureBoxStartEdges.Image = new Bitmap(pictureBoxStart.Image);
            SetImages();
        }

        private void SetImages()
        {
            MakeNoise();
            LoadMini();

            counted[0] = counted[1] = counted[2] = false;

            LoadResults();
        }

        private void LoadImage(string fileName)
        {
            pictureBoxStart.Image = new Bitmap(fileName);
            pictureBoxStartSharp.Image = new Bitmap(fileName);
            pictureBoxStartEdges.Image = new Bitmap(fileName);
            SetImages();
        }

        private void LoadMini() 
        {
            pictureBoxStartMini.Image = pictureBoxStart.Image;
            pictureBoxNoiseMini.Image = pictureBoxNoise.Image;
        }

        private void LoadResults()
        {
            if (tabControl.SelectedIndex == 1 && !counted[0])
            {
                CountSigma();

                FilterMedian();
                FilterGauss();

                counted[0] = true;
            }
            else if (tabControl.SelectedIndex == 2 && !counted[1])
            {
                FilterSharp();
                counted[1] = true;
            }
            else if (tabControl.SelectedIndex == 3 && !counted[2])
            {
                FilterEdges();
                counted[2] = true;
            }
        }

        private void MakeNoise()
        {
            Bitmap img = new Bitmap(pictureBoxStart.Image);

            Random rand = new Random();


            if (checkBoxNoise.Checked)
            {
                double prob = (double)trackBar6.Value / 100;
                int val = trackBar5.Value;

                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        if (rand.NextDouble() < prob)
                        {
                            Color pixel = img.GetPixel(x, y);

                            int R, G, B;

                            if (radioButtonBright.Checked)
                            {
                                int value = rand.Next(-val, val + 1);

                                R = pixel.R + value;
                                G = pixel.G + value;
                                B = pixel.B + value;
                            }
                            else
                            {
                                R = pixel.R + rand.Next(-val, val + 1);
                                G = pixel.G + rand.Next(-val, val + 1);
                                B = pixel.B + rand.Next(-val, val + 1);
                            }

                            img.SetPixel(x, y, Color.FromArgb(pixel.A, NormalizeColor(R), NormalizeColor(G), NormalizeColor(B)));
                        }
                    }
                }
            }

            pictureBoxNoise.Image = img;    
            pictureBoxNoiseMini.Image = img;
            counted[0] = false;
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
            LoadResults();
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

        private Bitmap MakeImgWithBordersCopy(PictureBox picture, int apert)
        {
            Bitmap imgStart = new Bitmap(picture.Image);

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
            Bitmap imgNoise = MakeImgWithBordersCopy(pictureBoxNoise, apert);
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
            Bitmap imgNoise = MakeImgWithBordersCopy(pictureBoxNoise, apert);
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

        private void FilterSharp()
        {
            Bitmap imgStart = MakeImgWithBordersCopy(pictureBoxStart, apertSharp);
            Bitmap img = new Bitmap(pictureBoxStart.Image);

            progressBar1.Visible = true;
            progressBar1.Maximum = img.Width * img.Height;
            progressBar1.Value = 0;

            int n = apertSharp * 2 + 1;
            int t = n * n - 1;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    double R = 0;
                    double G = 0;
                    double B = 0;

                    for (int k = 0; k < n; k++)
                    {
                        for (int l = 0; l < n; l++)
                        {
                            Color pixel = imgStart.GetPixel(i + l, j + k);

                            if (k == apertSharp && l == apertSharp)
                            {
                                R += pixel.R * (kSharp + 1);
                                G += pixel.G * (kSharp + 1);
                                B += pixel.B * (kSharp + 1);
                            }
                            else
                            {
                                R += pixel.R * (-kSharp / t);
                                G += pixel.G * (-kSharp / t);
                                B += pixel.B * (-kSharp / t);
                            }
                        }
                    }

                    img.SetPixel(i, j, Color.FromArgb(img.GetPixel(i, j).A, NormalizeColor(Convert.ToInt32(Math.Round(R))), NormalizeColor(Convert.ToInt32(Math.Round(G))), NormalizeColor(Convert.ToInt32(Math.Round(B)))));

                    progressBar1.Value += 1;
                }
            }

            progressBar1.Visible = false;

            pictureBoxSharp.Image = img;
        }

        private Bitmap MakeGrey(Bitmap colored)
        {
            Bitmap img = new Bitmap(colored);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = colored.GetPixel(i, j);

                    int brightness = NormalizeColor(Convert.ToInt32(Math.Round(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B)));

                    img.SetPixel(i, j, Color.FromArgb(pixel.A, brightness, brightness, brightness));
                }
            }

            return img;
        }

        private void FilterEdges()
        {
            Bitmap imgStart = MakeGrey(MakeImgWithBordersCopy(pictureBoxStart, 1));
            Bitmap imgHorizontal = new Bitmap(pictureBoxStart.Image);
            Bitmap imgVertical = new Bitmap(pictureBoxStart.Image);
            Bitmap img = new Bitmap(pictureBoxStart.Image);

            progressBar1.Visible = true;
            progressBar1.Maximum = img.Width * img.Height;
            progressBar1.Value = 0;

            int n = 3;

            int[] matrix = new int[9] { -1, -1, -1, 0, 0, 0, 1, 1, 1};

            if (algorithmSobel)
            {
                matrix[1] = -2;
                matrix[7] = 2;
            }

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    int Y = 0;

                    for (int k = 0; k < n; k++)
                    {
                        for (int l = 0; l < n; l++)
                        {
                            Color pixel = imgStart.GetPixel(i + l, j + k);

                            Y += pixel.R * (matrix[k * n + l] + matrix[l * n + k]);
                        }
                    }

                    Y = NormalizeColor(Y);

                    if (Y > alpha)
                    {
                        Y = 255;
                    }
                    else
                    {
                        Y = 0;
                    }

                    if (whiteBackground)
                    {
                        Y = 255 - Y;
                    }

                    img.SetPixel(i, j, Color.FromArgb(img.GetPixel(i, j).A, Y, Y, Y));

                    progressBar1.Value += 1;
                }
            }

            progressBar1.Visible = false;

            pictureBoxEdges.Image = img;
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

        private void TrackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            apertSharp = trackBar2.Value;

            FilterSharp();
        }

        private void TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
        }

        private void TrackBar3_MouseUp(object sender, MouseEventArgs e)
        {
            kSharp = (double)trackBar3.Value / 10;

            FilterSharp();
        }

        private void TrackBar3_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = (trackBar3.Value / 10).ToString() + "." + (trackBar3.Value % 10).ToString();
        }

        private void TrackBar4_MouseUp(object sender, MouseEventArgs e)
        {
            alpha = trackBar4.Value;

            FilterEdges();
        }

        private void TrackBar4_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = trackBar4.Value.ToString();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            whiteBackground = !radioButton1.Checked;
            FilterEdges();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            algorithmSobel = radioButton4.Checked;
            FilterEdges();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            MakeNoise();
        }

        private void RadioButtonBright_CheckedChanged(object sender, EventArgs e)
        {
            MakeNoise();
        }

        private void TrackBar5_MouseUp(object sender, MouseEventArgs e)
        {
            MakeNoise();
        }

        private void TrackBar5_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = trackBar5.Value.ToString();
        }

        private void TrackBar6_MouseUp(object sender, MouseEventArgs e)
        {
            MakeNoise();
        }

        private void TrackBar6_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = trackBar6.Value.ToString();
        }
    }
}
