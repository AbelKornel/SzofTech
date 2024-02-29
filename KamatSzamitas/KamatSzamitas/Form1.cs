using System.Text.Json;

namespace KamatSzamitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal hitel_osszeg = Convert.ToDecimal(textBoxHitelÖsszeg.Text);
            decimal havi_kamat = Convert.ToDecimal(textBoxHaviKamat.Text);
            decimal havi_torlesztes = Convert.ToDecimal(comboBoxHaviTörlesztés.Text);

            decimal hatralek = hitel_osszeg;

            int honapok = 1;
            decimal koltseg = 0;

            /*List<Sor> sorok = new List<Sor>();*/
            List<ExtraSor> extra_sorok = new List<ExtraSor>();

            while (hatralek > 0)
            {
                decimal kamat = hatralek * (havi_kamat / 100m);
                hatralek += kamat;
                hatralek -= havi_torlesztes;
                koltseg += havi_torlesztes;

                if (kamat > havi_torlesztes)
                {
                    MessageBox.Show("Túl nagy a kamat, túl kicsi  a havi törlesztés!");
                    break;

                }

                /*Sor új_sor = new Sor();
                új_sor.Hátralék = hatralek;
                új_sor.Hónap = honapok;

                sorok.Add(új_sor);*/

                ExtraSor extra = new ExtraSor();
                extra.Hátralék = hatralek;
                extra.Hónap = honapok;

                extra_sorok.Add(extra);

                honapok++;
            }

            koltseg += hatralek;

            dataGridView1.DataSource = extra_sorok;

            MessageBox.Show(koltseg.ToString());
        }
    }
}