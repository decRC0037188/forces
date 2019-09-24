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
    }
}
