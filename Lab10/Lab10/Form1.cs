using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point click;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            g.DrawRectangle(Pens.Silver, click.X, click.Y, 50, 50);
            Rectangle fillRect = new Rectangle(100, 100, 200, 200);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            click = e.Location;
            Random rand = new Random();
            int x = rand.Next(0, 1000);
            int y = rand.Next(0, 1000);
            int width = rand.Next(100, 200);
            int height = rand.Next(50, 150);
            g.FillEllipse(redBrush, x, y, width, height);
        }
    }
}
