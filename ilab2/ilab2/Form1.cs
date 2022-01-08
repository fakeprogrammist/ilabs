using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 14.26;
            double y = -1.22;
            double z = 0.035;
            textBox4.Text += "X = " + x + Environment.NewLine;
            textBox4.Text += "Y = " + y + Environment.NewLine;
            textBox4.Text += "Z = " + z + Environment.NewLine;
            double numer = 2 * Math.Cos(x - Math.PI / 6);
            double denom = 0.5 + Math.Pow(Math.Sin(y), 2);
            double num = 1 + (z * z) / (3 - z * z / 5);
            double t = numer/denom*num;
            textBox4.Text += "T = " + t + Environment.NewLine;
        }
    }
}
