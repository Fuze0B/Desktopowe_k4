using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void daneOsoboweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            listBox1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;

            textBox1.Text = "";
            listBox1.SelectedItem = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            label4.Visible = false;
            label5.Visible = false;
            listBox2.Visible = false;
            checkedListBox1.Visible = false;
            button3.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nazwisko = textBox1.Text;
            string uczelnia = listBox1.SelectedItem.ToString();
            string tryb = "";

            if (radioButton1.Checked)
                tryb = "Dzienne";
            else if (radioButton2.Checked)
                tryb = "Zaoczne";

            MessageBox.Show("Nazwisko: " + nazwisko +
                            "\nUczelnia: " + uczelnia +
                            "\nTryb: " + tryb);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string nazwisko = textBox1.Text;
            string uczelnia = listBox1.SelectedItem.ToString();
            string tryb = "";

            if (radioButton1.Checked)
                tryb = "Dzienne";
            else if (radioButton2.Checked)
                tryb = "Zaoczne";

            string dane = "Nazwisko: " + nazwisko +
                          "\nUczelnia: " + uczelnia +
                          "\nTryb: " + tryb;

            File.AppendAllText("zapis.txt", dane);
            MessageBox.Show("Zapisano do pliku");
        }

        private void inneInformacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            listBox2.Visible = true;
            checkedListBox1.Visible = true;
            button3.Visible = true;

            listBox2.SelectedItems.Clear();
            checkedListBox1.CheckedItems = false; 

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            listBox1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string jezyki = "Języki: ";
            foreach (var jezyk in listBox2.SelectedItems)
            {
                jezyki += jezyk.ToString() + ", ";
            }

            string hobby = "Hobby: ";
            foreach (var hobby1 in checkedListBox1.CheckedItems)
            {
                hobby += hobby1.ToString() + ", ";
            }

            MessageBox.Show(jezyki + "\n" + hobby);
        }

        private void hasłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            label4.Visible = false;
            label5.Visible = false;
            listBox2.Visible = false;
            checkedListBox1.Visible = false;
            button3.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            listBox1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

            textBox2.Text = File.ReadAllText("haslodl.txt");
            int dlugosc = int.Parse(textBox2.Text);

            Random rnd = new Random();

            string male = "abcdefghijklmnopqrstuvwxyz";
            string duze = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cyfry = "0123456789";
            string znaki = "!@#$%^&*";

            char[] haslo = new char[dlugosc];

            haslo[0] = duze[rnd.Next(duze.Length)];

            haslo[1] = cyfry[rnd.Next(cyfry.Length)];

            haslo[2] = znaki[rnd.Next(znaki.Length)];

            for (int i = 3; i < dlugosc; i++)
            {
                haslo[i] = male[rnd.Next(male.Length)];
            }
            string hasloString = new string(haslo);
            textBox3.Text = hasloString;
        }
    }
}
