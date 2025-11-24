using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String n = (String)textBox1.Text;
            if (checkBox1.Checked == true)
            {
                textBox2.Text = n + " uczeń";
            }
            else
            {
                textBox2.Text = n + " nie uczeń";
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += " | mężczyzna";
            }
            else if (radioButton1.Checked)
            {
                textBox2.Text += " | kobieta";
            }
            else
            {
                textBox2.Text += " nie wybrano";
            }
                textBox2.Text += " | języki: ";
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                textBox2.Text += "żaden";
            }
            else {
                foreach (object itemChecked in checkedListBox1.CheckedItems)
                {
                    textBox2.Text += itemChecked.ToString() + " ";
                }
                 }

            string wybMiejsce = comboBox1.SelectedItem.ToString();
            textBox3.Text = "Miejsce zamieszkania: "+wybMiejsce;
            //sposób 2 przed index, ale można też jak powyrzej 
            int wybIndex = listBox1.SelectedIndex;
            string wybWyksztalcenie = listBox1.Items[wybIndex].ToString();
            textBox3.Text += " | Wykształcenie: " + wybWyksztalcenie;
            textBox3.Text += " | Zainteresowania: ";
            foreach(var wybZainteresowania in listBox2.SelectedItems)
            {
                textBox3.Text += wybZainteresowania.ToString() + " ";
            }

        }
    }
}
