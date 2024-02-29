using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzorzoTabla
{
    internal class SzineződőGomb : Button
    {
        public SzineződőGomb()
        {
            int m = 20;
            Button button = new Button();
            button.Width = m;
            button.Height = m;
            MouseClick += SzineződőGomb_MouseClick;
        }

        private void SzineződőGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (BackColor == Color.Fuchsia)
            {
                BackColor = SystemColors.ButtonFace;
            }
            else
            {
                BackColor = Color.Fuchsia;
            }
        }
    }
}
