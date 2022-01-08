using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4;
            int[,] array = new int[3, 4];
            Random rand = new Random();
            int i, j;
            int min = 0;
            for (i = 0; i < 3;i++ )
                for(j=0; j<4; j++)
                {
                    array[i, j] = rand.Next(-15, 15);
                }
            for (i = 0; i < 3; i++)
                for (j = 0; j < 4; j++)
                    dataGridView1.Rows[i].Cells[j].Value = array[i, j].ToString();
            j = 0;
            i = 0;
            min = array[i, j];
            while (i < 3) 
            {
                while (j < 4) 
                {
                    if (array[i,j] < min)
                    {
                        min = array[i, j];
                    }
                    j++;
                }
                i++;
            }
            i = 1;
            j = 0;
            while (i < 3)
            {
                while (j < 4)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    j++;
                }
                i++;
            }
            i = 2;
            while (i < 3)
            {
                while (j < 4)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    j++;
                }
                i++;
            }
        }
        }
    }
}
