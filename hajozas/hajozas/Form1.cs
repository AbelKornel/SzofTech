namespace hajozas
{
    public partial class Form1 : Form
    {

        List<Kerdes> OsszesKerdes;
        List<Kerdes> AktualisKerdesek;
        int AktualisKerdes = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OsszesKerdes = KerdesBetoltes();
            AktualisKerdesek = new List<Kerdes>();
            for (int i = 1; i < 7; i++)
            {
                AktualisKerdesek.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKerdesek;
        }

        List<Kerdes> KerdesBetoltes()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
    }
}