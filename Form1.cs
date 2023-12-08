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

        private void MakeNoise()
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            double prob = 0.2;
            int val = 50;

            Random rand = new Random();

            for (int x = 0; x < img.Width; x++) 
            {
                for (int y = 0; y < img.Height; y++)
                {
                    if (rand.NextDouble() < prob)
                    {
                        Color pixel = img.GetPixel(x, y);

                        int R, G, B;

                        R = pixel.R + rand.Next(-val, val + 1);
                        G = pixel.G + rand.Next(-val, val + 1);
                        B = pixel.B + rand.Next(-val, val + 1);

                        img.SetPixel(x, y, Color.FromArgb(pixel.A, NormalizeColor(R), NormalizeColor(G), NormalizeColor(B)));
                    }
                }
            }

            pictureBox2.Image = img;        
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
    }
}
