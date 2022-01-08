using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countofones = 0;
            int countof0 = 0;
            string str = (string)listBox1.Items[0];
            int len = str.Length;
            int i = 0;
            while (i < len)
            {
                if (str[i] == 1)
                {
                    countofones += 1;
                }s
                else 
                {
                    countof0 += 1;
                }
                i++;
            }
            textBox1.Text += "Count of 0: " + countof0 + Environment.NewLine + "Count of 1: " + countofones;
        }
    }
}
