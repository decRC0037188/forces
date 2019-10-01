using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double X)
        {
            return (Math.Sin(X * Math.PI / 180.0));
        }
        double asin(double X)
        {
            return (Math.Asin(X) * 180 / Math.PI);
        }
        double cos(double X)
        {
            return (Math.Cos(X * Math.PI / 180.0));
        }


            private void Button1_Click(object sender, EventArgs e)
            {
               
            }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            double Force = double.Parse(textBox2.Text);
            double Angle = double.Parse(textBox1.Text);

            double fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);

            label1.Text = "Fx = " + fx;
            label2.Text = "Fy = " + Fy;
        }
    }
}
