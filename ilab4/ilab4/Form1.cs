using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = -1.25;
            double b = -1.5;
            double c = 0.75;
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dk = Convert.ToDouble(textBox3.Text);
            double y = 0; 
            while (x0 < xk) 
            {
                y = (b * c) / (x0 * 100) + Math.Cos(Math.Sqrt(Math.Pow(a,3)* x0));
                textBox4.Text += "x = " + x0.ToString() + " y = " + y.ToString() + Environment.NewLine;
                x0 += dk;            
            }
        }
    }
}
