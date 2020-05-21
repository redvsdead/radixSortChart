using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radixSortChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        radixSorter sorter = new radixSorter();

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart2.Series.ElementAt(0).Points.Clear();
            this.chart2.Series.ElementAt(1).Points.Clear();
            this.chart2.Series.ElementAt(2).Points.Clear();
            int size = 0;
            while (size <= 100)
            {
                char[] array = new char[size];
                for (int i = 0; i < size; ++i)
                {
                    array[i] = (char)rnd.Next();
                }

                sorter.sorting(array);
                this.chart2.Series.ElementAt(0).Points.AddXY(size, sorter.sysBase);
                this.chart2.Series.ElementAt(1).Points.AddXY(size, sorter.maxCount);
                this.chart2.Series.ElementAt(2).Points.AddXY(size, sorter.runTime);
                
                size += 10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series.ElementAt(0).Points.Clear();
            this.chart1.Series.ElementAt(1).Points.Clear();
            this.chart1.Series.ElementAt(2).Points.Clear();
            int size = 0;
            while (size <= 1000)
            {
                char[] array = new char[size];
                for (int i = 0; i < size; ++i)
                {
                    array[i] = (char)rnd.Next();
                }

                sorter.sorting(array);
                this.chart1.Series.ElementAt(0).Points.AddXY(size, sorter.sysBase);
                this.chart1.Series.ElementAt(1).Points.AddXY(size, sorter.maxCount);
                this.chart1.Series.ElementAt(2).Points.AddXY(size, sorter.runTime);

                size += 10;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.chart3.Series.ElementAt(0).Points.Clear();
            this.chart3.Series.ElementAt(1).Points.Clear();
            this.chart3.Series.ElementAt(2).Points.Clear();
            int size = 0;
            while (size <= 10000)
            {
                char[] array = new char[size];
                for (int i = 0; i < size; ++i)
                {
                    array[i] = (char)rnd.Next();
                }

                sorter.sorting(array);
                this.chart3.Series.ElementAt(0).Points.AddXY(size, sorter.sysBase);
                this.chart3.Series.ElementAt(1).Points.AddXY(size, sorter.maxCount);
                this.chart3.Series.ElementAt(2).Points.AddXY(size, sorter.runTime);

                size += 10;
            }
        }
    }
}
