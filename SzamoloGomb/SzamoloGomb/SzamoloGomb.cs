using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamoloGomb
{
    
    internal class SzamoloGomb : Button
    {
        int szam;
        public SzamoloGomb()
        {
            szam = 1;
            Width = 20;
            Height = 20;
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szam++;
            if (szam == 6)
            {
                szam = 1;
            }
            Text = szam.ToString();

        }
    }
}
