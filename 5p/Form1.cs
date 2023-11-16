using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radious, height;
            double basearea, lateralarea, totalarea;
            double volumen;

            radious = double.Parse(textBox1.Text);
            height = double.Parse(textBox2.Text);

            basearea = radious * radious * Math.PI;
            lateralarea = 2 * Math.PI * radious * height;
            totalarea = 2 * Math.PI * radious * (height + radious);
            volumen = Math.PI * radious * radious * height;

            textBox3.Text = basearea.ToString("0.##");
            textBox4.Text = lateralarea.ToString("0.##");
            textBox5.Text = totalarea.ToString("0##");
            textBox6.Text = volumen.ToString("0##");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    } 
  

}
