namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        int m�ret = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Height = m�ret;
            b.Width = m�ret;
            b.Left = ClientRectangle.Width / 2 - m�ret / 2;
            b.Top = ClientRectangle.Height / 2 - m�ret / 2;
            Controls.Add(b);
        }
    }
}