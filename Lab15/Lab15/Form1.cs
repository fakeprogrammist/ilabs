using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] Mas = new double[10]; 
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Mas[i] = rand.Next(-15, 15);
                textBox1.Text += "Mas[" + i + "] = " + Mas[i] + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            static int QuickSort(double[] arr, int left, int right)
            {
                int i = left;
                int counter = 0;
                int k = right;
                double p = arr[(left + right) / 2];
                do
                {
                    while (arr[i] < p && i < right) i++;
                    while (p < arr[k] && k > left) k--;
                    if (i <= k)
                    {
                        double temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                        i++;
                        k--;
                        counter++;
                    }
                } while (i <= k);
                if (left < k) QuickSort(arr, left, k);
                if (i < right) QuickSort(arr, i, right);
                return counter;
            }
            textBox2.Text += "Количество итераций Quick:" + QuickSort(Mas, 0, 9);
            static int SelectionSort(double[] array) 
            {
                int counter = 0;
                for(int i = 0; i<array.Length - 1; i++) 
                {
                    int min = i;
                    for (int j = i + 1; j< array.Length; j++) 
                    {
                        if(array[j] < array[min]) 
                        {
                            min = j;
                            counter++;
                        }
                    }
                    if (min!= i) 
                    {
                        double t = array[i];
                        array[i] = array[min];
                        array[min] = t;
                        counter++;
                    }
                }
                return counter;
            }
            textBox2.Text += "Количество итераций Selection:" + SelectionSort(Mas);
            double temp;
            int bubblecount = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int sort = 0; sort < Mas.Length - 1; sort++)
                {
                    if (Mas[sort] > Mas[sort + 1])
                    {
                        bubblecount += 1;
                        temp = Mas[sort + 1];
                        Mas[sort + 1] = Mas[sort];
                        Mas[sort] = temp;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                textBox2.Text += "Mas[" + i + "] = " + Mas[i] + Environment.NewLine;
            }
            textBox2.Text += "Количество итераций Bubble:" + bubblecount;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
