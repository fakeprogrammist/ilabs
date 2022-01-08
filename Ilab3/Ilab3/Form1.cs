using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ilab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double func = x * x;
            double res = 0;
            if (x * y > 0)
            {
                res = Math.Pow(x * x + y, 2) - Math.Sqrt(x * x);
                textBox3.Text = "Result will be: " + res + Environment.NewLine;
            }
            else if (x * y < 0)
            {
                res = Math.Pow(x * x + y, 2) - Math.Sqrt(Math.Abs(x * x * y));
                textBox3.Text = "Result will be: " + res + Environment.NewLine;
            }
            else if (x * y == 0) 
            {
                res = Math.Pow(x * x + y, 2) + 1;
                textBox3.Text = "Result will be: " + res + Environment.NewLine;
            }
         }
    }
}
