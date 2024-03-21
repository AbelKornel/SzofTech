namespace KígyóGame
{
    public partial class Form1 : Form
    {

        int fej_x = 100;
        int fej_y = 100;
        int alma_x;
        int alma_y;
        int irány_x = 1;
        int irány_y = 0;
        int lépés_szám;
        int hossz = 5;
        List<KigyoElem> kigyó = new List<KigyoElem>();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépés_szám++;

            fej_x += irány_x * KigyoElem.Méret;
            fej_y += irány_y * KigyoElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

                if (item is Alma)
                {
                    Alma a = (Alma)item;

                    if (fej_y == a.Top && fej_x == a.Left)
                    {
                        hossz++;
                        Controls.Remove(a);
                    }
                }
            }


            KigyoElem ke = new KigyoElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kigyó.Add(ke);

            Controls.Add(ke);

            if (kigyó.Count > hossz)
            {
                KigyoElem levágandó = kigyó[0];
                kigyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }



            if (lépés_szám % 2 == 0)
            {
                ke.BackColor = Color.Yellow;
            }

            if (lépés_szám % 7 == 0)
            {
                alma_x = rnd.Next(1, ClientRectangle.Width / KigyoElem.Méret) * KigyoElem.Méret;
                alma_y = rnd.Next(1, ClientRectangle.Width / KigyoElem.Méret) * KigyoElem.Méret;

                Alma alma = new Alma();
                alma.Top = alma_x;
                alma.Left = alma_y;
                Controls.Add(alma);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            
        }
    }
}