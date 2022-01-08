using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ilab11
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer() { Interval = 200 };
        bool beat = false;
        public Form1()
        {
            InitializeComponent();
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            SolidBrush peg = new SolidBrush(Color.Red);
            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            gp.AddEllipse(40, 60, 100, 150);
            gp.AddEllipse(125, 60, 100, 150);
            gp.AddPolygon(new Point[] { new Point(48, 176), new Point(218, 176), new Point(140, 280) });
            if (beat) g.ScaleTransform(0.95f, 0.95f);
            g.FillPath(peg, gp);
            g.ResetTransform();
            beat = !beat;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            SolidBrush peg = new SolidBrush(Color.Red);
            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            gp.AddEllipse(40, 60, 100, 150);
            gp.AddEllipse(125, 60, 100, 150);
            gp.AddPolygon(new Point[] { new Point(48, 176), new Point(218, 176), new Point(140, 280) });
            if (beat) g.ScaleTransform(0.95f, 0.95f);
            g.FillPath(peg, gp);
            g.ResetTransform();
            beat = !beat;
        }
    }
}
