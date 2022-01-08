using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MyDraw(Graphics g, int N, int x, int y)
        {
            int start_x = this.Width / 2;
            int start_y = this.Height / 2;
            for (int i = 0; i < N; i++)
            {
                g.DrawEllipse(new Pen(Brushes.Blue, 2), start_x - x, start_y - y, x * 2, y * 2);
                x += 10;
                y += 10;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MyDraw(g, 7, 10, 10);
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MyDraw(g, 7, 10, 10);
        }
    }
}
