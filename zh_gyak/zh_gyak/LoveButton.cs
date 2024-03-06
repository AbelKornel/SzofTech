using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_gyak
{
    internal class LoveButton : Label
    {
        int szam = 1;
        public LoveButton()
        {
            BackColor = Color.White;
            MouseClick += LoveButton_MouseClick;
            AutoSize = true;
            //Text = szam.ToString();
            Text = "\u2764";
        }

        private void LoveButton_MouseClick(object? sender, MouseEventArgs e)
        {
            szam++;
            if (szam == 4)
            {
                szam = 1;
            }
            //Text = $"A szám {szam} \u2764";

            Text = "";
            for (int i = 0; i < szam; i++)
            {
                Text += "\u2764";
            }
        }
    }
}
