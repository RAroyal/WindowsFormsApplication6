using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
      


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            if (radioButton1.Checked == true)
            {
                double f,g,h,m;
                f = Math.Sin(x);
                g = Math.Sin(y);
                h = Math.Sin(z);
                double[] ar = { f, g, h };
                double[] at = { f, g};
                double maxValue = Math.Round(ar.Max<double>(),4);
                double MinValue = Math.Round(at.Min<double>(),4);
                m = Math.Round((maxValue / MinValue + 5), 4);
                textBox4.Text = Convert.ToString("максимальное значение = " + 
                    maxValue + Environment.NewLine +  "минимальное значение = " +
                    MinValue + Environment.NewLine + "Результат функции равен =" + m);
                

            }
            if (radioButton2.Checked == true)
            {
                double f, g, h, m;
                f = Math.Pow(x, 2);
                g = Math.Pow(y, 2);
                h = Math.Pow(z, 2);
                double[] ar = { f, g, h };
                double[] at = { f, g };
                double maxValue = Math.Round(ar.Max<double>(), 4);
                double MinValue = Math.Round(at.Min<double>(), 4);
                m = Math.Round((maxValue / MinValue + 5), 4);
                textBox4.Text = Convert.ToString("максимальное значение = " +
                   maxValue + Environment.NewLine + "минимальное значение = " +
                   MinValue + Environment.NewLine + "Результат функции равен =" + m);
                
            }

            if (radioButton3.Checked == true)
            {
                double f, g, h, m;
                f = Math.Pow(Math.E, x);
                g = Math.Pow(Math.E, y);
                h = Math.Pow(Math.E, z);
                double[] ar = { f, g, h };
                double[] at = { f, g};
                double maxValue = Math.Round(ar.Max<double>(), 4);
                double MinValue = Math.Round(at.Min<double>(), 4);
                m = Math.Round((maxValue / MinValue + 5),4);
                textBox4.Text = Convert.ToString("максимальное значение = " +
                   maxValue + Environment.NewLine + "минимальное значение = " +
                   MinValue + Environment.NewLine + "Результат функции равен =" + m);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

 

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            

            if (label6.Left < this.Width)
            {
                label6.Left += 1;
            }
            else
            {
                label6.Left = -label6.Width;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button3.Visible = false;

        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button3.Visible = true;
        }

        
    }
}
