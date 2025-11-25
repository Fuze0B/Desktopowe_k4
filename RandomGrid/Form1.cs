using System;
using System.Windows.Forms;

namespace RandomGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] tab;

        public void sort(int[] tab,int rozmiar)
        {
            int temp;
            for(int i = 0; i < rozmiar - 1; i++)
            {
                for(int j = 0; j < rozmiar - 1; j++)
                {
                    if (tab[j] > tab[j+1])
                    {
                        temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
            for(int k=0;k< rozmiar; k++)
            {
                dataGridView2.Rows[0].Cells[k].Value = tab[k];
            }
            
        }
        public int szukaj(int[] tab, int p, int k, int s)
        {
            int middleIndex;
            while (p <= k)
            {
                middleIndex = (p + k) / 2;
                if (tab[middleIndex] == s)
                {
                    return middleIndex;
                }
                else if (s < tab[middleIndex])
                {
                    k = middleIndex - 1;
                }
                else
                {
                    p = middleIndex + 1;
                }
            }
                return -1;
        }

        public int szukaj2(int[] tab, int p, int k, int s)
        {
            if (p > k)
                return -1;

            int srodek = (p + k) / 2;

            if (tab[srodek] == s)
            {
                return srodek;
            }
            else if (s < tab[srodek])
            {
                return szukaj2(tab, p, srodek-1, s);
            }
            else
            {
                return szukaj2(tab,srodek + 1, k, s);
            }
        }

        public void scalanie(int[] tab, int p, int k)
        {
            int[] temp = new int [tab.Length];

            int i = p;
            int i1 = p;
            int srodek = (p + k) / 2;
            int i2 = srodek+1;
            for(i = 0; i < tab.Length; i++)
            {
                temp[i] = tab[i];
            }
            i = p;
            while(i1 <= srodek && i2 <= k)
            {
                if (temp[i1] < temp[i2])
                {
                    tab[i] = temp[i1];
                    i1++;
                }
                else
                {
                    tab[i] = temp[i2];
                    i2++;
                }
                i++;
            }
            if(i1 > srodek)
            {
                while(i2 <= k)
                {
                    tab[i] = temp[i2];
                    i2++;
                    i++;
                }
            }
            if(i2 > k)
            {
                while(i1 <= srodek)
                {
                    tab[i] = temp[i1];
                    i1++;
                    i++;
                }
            }


        }
        public void mergeSort(int[] tab, int p, int k)
        {
            int srodek = (p + k) / 2;
            if(p < srodek)
            {
                mergeSort(tab, p, srodek);
            }
            if(srodek + 1 < k)
            {
                mergeSort(tab, srodek + 1,k);
            }
            scalanie(tab, p, k);
        }

        public void quickSort(int[] tab, int l, int p)
        {
            int v = tab[(l + p) / 2];
            int i, j, temp;
            i = l;
            j = p;
            do
            {
                while (tab[i] < v) i++;
                while (tab[j] > v) j--;
                if (i <= j)
                {
                    temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (j > l)
            {
                quickSort(tab, l, j);
            }
            if (i < p)
            {
                quickSort(tab, i, p);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            dataGridView2.Visible = false;

            tab = new int[dataGridView1.Columns.Count];
            Random random = new Random();
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    tab[j] = random.Next(1, 100);
                    dataGridView1.Rows[0].Cells[j].Value = tab[j];
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label1.Text = "Min: ";
            int min = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            textBox1.Text = min.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label1.Text = "Max: ";
            int max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }
            textBox1.Text = max.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            textBox3.Visible = true;
            dataGridView2.Visible = true;
            quickSort(tab, 0,5);
            for (int k = 0; k < 6; k++)
            {
                dataGridView2.Rows[0].Cells[k].Value = tab[k];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
                label2.Visible = true;
            if (int.TryParse(textBox3.Text, out int b))
            {
                int wynik = szukaj(tab, 0, tab.Length - 1, b);

                if (wynik != -1)
                    label2.Text = $"Znaleziono element {b} na pozycji {wynik}";
                else
                    label2.Text = $"Nie znaleziono elementu {b}";
            }
            else
            {
                label2.Text = "Wpisz liczbę w polu tekstowym!";
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
