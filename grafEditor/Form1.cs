using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafEditor
{
    public partial class Form1 : Form
    {
        public Bitmap image1;
        public int strtX,strtY,endX,endY;
        public bool penc, line, rect, circ, fill;
        public Color clr = Color.FromArgb(255, 0, 0);
        public string str = "penc";

        private void circButton_Click(object sender, EventArgs e)
        {
            penc = false;
            line = false;
            rect = false;
            circ = true;
            fill = false;
        }

        private void buckButton_Click(object sender, EventArgs e)
        {
            penc = false;
            line = false;
            rect = false;
            circ = false;
            fill = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            image1.SetPixel(e.X, e.Y, Color.FromArgb(255, 0, 0));
            pictureBox1.Image = image1;
        }

        private void rectButton_Click(object sender, EventArgs e)
        {
            penc = false;
            line = false;
            rect = true;
            circ = false;
            fill = false;
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            penc = false;
            line = true;
            rect = false;
            circ = false;
            fill = false;
        }

        private void pencilButton_Click(object sender, EventArgs e)
        {
            penc = true;
            line = false;
            rect = false;
            circ = false;
            fill = false;
        }

        public Form1()
        {
            InitializeComponent();
            image1 = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);

            int x, y;


            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                    image1.SetPixel(x, y, newColor);
                }
            }


            pictureBox1.Image = image1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
                image1 = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);

                int x, y;

               
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        Color pixelColor = image1.GetPixel(x, y);
                        Color newColor = Color.FromArgb(255, 255, 255);
                        image1.SetPixel(x, y, newColor);
                    }
                }

               
                pictureBox1.Image = image1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            strtX = e.X;
            strtY = e.Y;
            if (line)
            {
                str = "line";
            }
            else if (rect)
            {
                str = "rect";
            }
            else if (circ)
            {
                str = "circ";
            }
            else if (fill)
            {
                str = "fill";
            }
            else
            {
                str = "penc";          
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            endX = e.X;
            endY = e.Y;
            int x = 0;
            int y = 0;
            switch (str) {
                case "line":
                    int xerr = 0;
                    int yerr = 0;
                    int dx = endX - strtX;
                    int dy = endY - strtY;
                    int incX = 0, incY = 0;
                    if (dx > 0)
                        incX = 1;
                    else if(dx == 0)
                        incX = 0;
                    else if(dx < 0)
                        incX = -1;
                    if (dy > 0)
                        incY = 1;
                    else if(dy == 0)
                        incY = 0;
                    else if(dy < 0)
                        incY = -1;
                    dx = Math.Abs(dx);
                    dy = Math.Abs(dy);
                    int d;
                    if (dx > dy)
                        d = dx;
                    else
                        d = dy;
                    x = strtX; y = strtY;
                    image1.SetPixel(x,y, clr);
                    for (int i = 0; i < d; i++) {
                        xerr += dx;
                        yerr += dy;
                        if (xerr > d)
                        {
                            xerr = xerr - d;
                            x += incX;
                        }
                        if (yerr > d) {
                            yerr = yerr - d;
                            y += incY;
                        }
                        image1.SetPixel(x,y,clr);
                    }
                    pictureBox1.Image = image1;
                    break;
            }
        }
    }
}
