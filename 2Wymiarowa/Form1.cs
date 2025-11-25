using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Wymiarowa
{
    public partial class Form1 : Form
    {
        int s;
        int s2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(7);
            dataGridView2.Rows.Add(7);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(1, 10);
                }
            }
        }

       private void button1_Click(object sender, EventArgs e) { 
            textBox1.Visible = true;
            label1.Visible = true;


            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 0;j < dataGridView1.Columns.Count; j++)
                {
                    s +=  (int)dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            textBox1.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s2 = 0;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 0; j < dataGridView1.Columns.Count ; j++)
                {
                    s2 += (int)dataGridView1.Rows[i].Cells[j].Value;
                }
                dataGridView2.Rows[i].Cells[0].Value = s2;
                s2 = 0;
            }
        }
    }
}
