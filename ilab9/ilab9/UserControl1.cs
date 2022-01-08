using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilab9
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1,5";
            textBox2.Text = "3,5";
            textBox3.Text = "0,5";
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double Step = double.Parse(textBox3.Text);
            double a = 1.25;
            double b = 1.5;
            double c = 0.75;
            double X = Xmin;
            this.chart1.Series[0].Points.Clear();
            while (X <= Xmax)
            {
                double y =b*c/X/100 * Math.Cos(Math.Pow(a, 1/3)*X);
                this.chart1.Series[0].Points.AddXY(X, y);
                X += Step;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
