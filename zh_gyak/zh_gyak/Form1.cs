using System.Globalization;

namespace zh_gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                LoveButton loveButton = new();
                loveButton.Top = (loveButton.Height + 1) * i;
                loveButton.Left = ClientRectangle.Width / 2;

                Controls.Add(loveButton);
            }
        }

        int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sorok_szama = int.Parse(textBox1.Text);

            Random rnd = new Random();
            List<RacsEgySora> sorok = new List<RacsEgySora>();

            for (int i = 0; i < sorok_szama; i++)
            {
                int veletlen = rnd.Next(1, 7);
                RacsEgySora racsEgySora = new RacsEgySora();

                racsEgySora.Sorszam = i;
                racsEgySora.VéletlenSzam = veletlen;
                racsEgySora.Fibonacci = Fibonacci(i);

                sorok.Add(racsEgySora);
            }

            dataGridView1.DataSource = sorok;
        }
    }
}