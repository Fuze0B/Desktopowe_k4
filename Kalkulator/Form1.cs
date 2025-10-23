using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
                textBox2.Visible = true;    
                label3.Visible = true;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float w = a + b;
                textBox3.Text = w.ToString();
            }
            else
            {
                textBox3.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label3.Visible = true;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float w = a - b;
                textBox3.Text = w.ToString();
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label3.Visible = true;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float w = a * b;
                textBox3.Text = w.ToString();
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label3.Visible = true;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                if (b == 0)
                {
                    textBox3.Text = "Nie można dzielic przez 0";
                }
                else
                {
                    float c = a / b;
                    textBox3.Text = c.ToString();
                }
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label3.Visible = true;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                if (Math.Ceiling(a) == a && Math.Ceiling(b) == b && a > 0 && b > 0)
                {
                    a = (float)Math.Ceiling((float)a);
                    b = (float)Math.Ceiling((float)b);

                    while (a != b)
                    {
                        if (a > b)
                        {
                            a = a - b;
                        }
                        else
                        {
                            b = b - a;
                        }
                    }
                    textBox3.Text = a.ToString();

                }
                else
                {
                    textBox3.Text = "Nie właściwe liczby";
                }
            }
            else
            {
                textBox3.Text = "";
            }
        }

        float potega(float a,float b)
        {
            float w = 1;

            for (int i = 0; i < b; i++)
            {
                w = w * a;
            }
            return w;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label3.Visible = true;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                if (Math.Ceiling(b) == b)
                {
                    b = (float)Math.Ceiling((float)b);
                    float c = potega(a, b);
                    textBox3.Text = c.ToString();
                }
                else
                {
                    textBox3.Text = "Podaj wykładnik całkowity";
                }
            }
            else
            {
                textBox3.Text = "";
            }   


        }
        float suma_cyfr(float a)
        {
            float s = 0;
            while (a != 0)
            {

                float r = a % 10;
                s += r;
                a = (a-r)/ 10;
            }
            return s;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            textBox2.Visible = false;
            label3.Visible = false;
            float c = suma_cyfr(a);
            textBox3.Text = c.ToString();
        }
        float silnia(int n)
        {
            float w = 0;
            if (n == 0)
            {
                w = 1;
            }
            else
            {
                return silnia(n - 1) * n;
            }
            return w;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox2.Visible = false;
            if (textBox1.Text != "")
            {
                float a = float.Parse(textBox1.Text);

                if (Math.Floor(a) != a)
                {
                    textBox3.Text = "Liczba musi być całkowita";
                }
                else if (a >= 0)
                {
                    int c = int.Parse(textBox1.Text);
                    float wynik = silnia(c);
                    textBox3.Text = wynik.ToString();
                }
                else
                {
                    textBox3.Text = "Liczba nie może być ujemna";
                }
            }
            else
            {
                textBox3.Text = "";
            }
        }

        string Binarne(int a)
        {
            int[] tab = new int[32];
            int i = 0;

            if(a == 0)
            {
                return "0";
            }
            while (a != 0)
            {
                tab[i] = a % 2;
                a = a / 2;
                i++;
            }
            string wynik = "";
            for(int j = i - 1; j >= 0; j--)
            {
                wynik+= tab[j].ToString();
            }
            return wynik;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox2.Visible = false;

            if (textBox1.Text != "")
            {
                
                float a = float.Parse(textBox1.Text);
                string c = Binarne((int)a);
                textBox3.Text = c.ToString();
            }
            else
            {
                textBox3.Text = " ";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
