namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string haslo = "";
        private void button1_Click(object sender, EventArgs e)
        {
            int dlugoscHasla = int.Parse(textBox3.Text);
            char[] znakiMale = new char[] {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                };
            char[] obaZnaki = new char[]
                {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
                };
            char[] cyfry = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            char[] specialne = {
                '!','@','#','$','%','^','&','*','(',')','-','_','=','+','[',']','{','}',';',':','"','\'','<','>',',','.','?','/'
            };

            List<char> dostepne = new List<char>();
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                dostepne.AddRange(znakiMale);

            if (checkBox1.Checked)
                dostepne.AddRange(obaZnaki);

            if (checkBox2.Checked)
            {
                dostepne.AddRange(cyfry);
                dostepne.AddRange(znakiMale);
            }

            if (checkBox3.Checked)
            {
                dostepne.AddRange(specialne);
                dostepne.AddRange(znakiMale);
            }
            Random rnd = new Random();
            for (int i = 0; i < dlugoscHasla; i++)
            {
                haslo += dostepne[rnd.Next(dostepne.Count)];
            }
            MessageBox.Show(haslo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && haslo != "")
            {
                MessageBox.Show("Imiê: " + textBox1.Text +"\n"+"Nazwisko: " + textBox2.Text + "\n"+ "Satnowisko: " + textBox3.Text + "\n" + "Has³o: " + haslo);
            }
        }
    }
}
