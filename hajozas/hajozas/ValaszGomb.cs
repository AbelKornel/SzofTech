using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajozas
{
    internal class ValaszGomb : TextBox
    {
        public ValaszGomb()
        {
            ReadOnly = true;
            BackColor = Color.Gray;
            BorderStyle = BorderStyle.None;
            Multiline = true;
            Width = 400;
            Height = 80;

        }
    }
}
