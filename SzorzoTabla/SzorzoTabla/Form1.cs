namespace SzorzoTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    Szinez�d�Gomb button = new Szinez�d�Gomb();
                    button.Width = 40;
                    button.Height = 40;
                    button.Left = oszlop * 40;
                    button.Top = sor * 40;
                    button.Text = ((sor + 1) * (oszlop + 1)).ToString();
                    Controls.Add(button);
                }
                
            }
        }
    }
}