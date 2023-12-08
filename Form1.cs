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

            double prob = 0.4;
            int val = 70;
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
        }
    }
}
