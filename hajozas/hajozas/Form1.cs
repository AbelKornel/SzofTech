namespace hajozas
{
    public partial class Form1 : Form
    {

        List<Kerdes> OsszesKerdes;
        List<Kerdes> AktualisKerdesek;

        ValaszGomb ValaszGomb1;
        ValaszGomb ValaszGomb2;
        ValaszGomb ValaszGomb3;

        int AktualisKerdes = 5;
        public Form1()
        {
            InitializeComponent();
            ValaszGomb1 = new ValaszGomb();
            ValaszGomb1.Top = 50;
            Controls.Add(ValaszGomb1);

            ValaszGomb2 = new ValaszGomb();
            ValaszGomb2.Top = 150;
            Controls.Add(ValaszGomb2);

            ValaszGomb3 = new ValaszGomb();
            ValaszGomb3.Top = 250;
            Controls.Add(ValaszGomb3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OsszesKerdes = KerdesBetoltes();
            AktualisKerdesek = new List<Kerdes>();
            for (int i = 0; i < 7; i++)
            {
                AktualisKerdesek.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKerdesek;

            KerdesMegjelenites(AktualisKerdesek[AktualisKerdes]);
        }

        void KerdesMegjelenites(Kerdes kerdes)
        {
            label1.Text = kerdes.KerdesSzoveg;
            ValaszGomb1.Text = kerdes.Valasz1;
            ValaszGomb2.Text = kerdes.Valasz2;
            ValaszGomb3.Text = kerdes.Valasz3;

            if (string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
            }
        }

        List<Kerdes> KerdesBetoltes()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();


            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] tomb = sor.Split("\t");
                // if (tomb.Length != 7) continue;
                Kerdes k = new Kerdes();
                k.KerdesSzoveg = tomb[1];
                k.Valasz1 = tomb[2];
                k.Valasz2 = tomb[3];
                k.Valasz3 = tomb[4];
                k.URL = tomb[5];

                int x = 0;
                int.TryParse(tomb[6], out x);

                k.HelyesValasz = x;

                kerdesek.Add(k);
            }
            sr.Close();

            return kerdesek;
        }

        private void valaszGomb4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}