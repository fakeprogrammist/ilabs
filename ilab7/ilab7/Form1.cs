using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int[] array = new int[20];
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int i = 0;
            while (i < 20) 
            {
                array[i] = rand.Next(0, 15);
                listBox1.Items.Add ("Mas[" + i + "] = " + array[i].ToString() + ";" + Environment.NewLine);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            int index = 0;
            while (i < 20) 
            {
                if (array[i] > array[index])
                    index = i;
                listBox2.Items.Add("Mas[" + i + "] = " + array[i].ToString() + ";" + Environment.NewLine);
                i++;
            }
            int b = 0;
            array[0] = b;
            array[0] = array[index];
            array[index] = b;
        }
    }
}
