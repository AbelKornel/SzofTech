namespace SzamoloGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzamoloGomb szamoloGomb = new SzamoloGomb();
                    szamoloGomb.Height = 20;
                    szamoloGomb.Width = 20;
                    szamoloGomb.Top = sor * 20;
                    szamoloGomb.Left = oszlop * 20;
                    Controls.Add(szamoloGomb);
                }
            }
        }
    }
}