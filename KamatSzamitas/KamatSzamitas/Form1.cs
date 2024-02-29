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
            decimal hitel_osszeg = Convert.ToDecimal(textBoxHitel�sszeg.Text);
            decimal havi_kamat = Convert.ToDecimal(textBoxHaviKamat.Text);
            decimal havi_torlesztes = Convert.ToDecimal(comboBoxHaviT�rleszt�s.Text);

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
                    MessageBox.Show("T�l nagy a kamat, t�l kicsi  a havi t�rleszt�s!");
                    break;

                }

                /*Sor �j_sor = new Sor();
                �j_sor.H�tral�k = hatralek;
                �j_sor.H�nap = honapok;

                sorok.Add(�j_sor);*/

                ExtraSor extra = new ExtraSor();
                extra.H�tral�k = hatralek;
                extra.H�nap = honapok;

                extra_sorok.Add(extra);

                honapok++;
            }

            koltseg += hatralek;

            dataGridView1.DataSource = extra_sorok;

            MessageBox.Show(koltseg.ToString());
        }
    }
}