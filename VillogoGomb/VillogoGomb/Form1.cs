namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        int méret = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Height = méret;
            b.Width = méret;
            b.Left = ClientRectangle.Width / 2 - méret / 2;
            b.Top = ClientRectangle.Height / 2 - méret / 2;
            Controls.Add(b);
        }
    }
}