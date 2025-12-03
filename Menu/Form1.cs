using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        float a = 0;
        float b = 0;
        int wybor;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float obw = 0;
            float pole = 0;
            float r = 0;
            if (wybor == 1)
            {
                r = float.Parse(textBox1.Text);
                pole = (float)Math.PI * r * r;
                textBox3.Text = pole.ToString();
            }
            if (wybor == 2)
            {
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);
                pole = a * b;
                textBox3.Text = pole.ToString();
            }
            if (wybor == 3)
            {
                r = float.Parse(textBox1.Text);
                obw = (float)(2 * Math.PI * r);
                textBox3.Text = obw.ToString();
            }
            if (wybor == 4) 
            {
                a = float.Parse(textBox1.Text);
                obw = a * 4;
                textBox3.Text = obw.ToString();
            }

        }
        private void kołoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wybor = 1;
            label1.Visible = true;
            textBox1.Visible = true;
            label1.Text = "Podaj r: ";
            button1.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void prostokatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wybor = 2;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Text = "Podaj a: ";
            label2.Text = "Podaj b: ";
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void kołoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wybor = 3;
            label1.Visible = true;
            textBox1.Visible = true;
            label1.Text = "Podaj r: ";
            button1.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void kwadratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wybor = 4;
            label1.Visible = true;
            textBox1.Visible = true;
            label1.Text = "Podaj a: ";
            button1.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
