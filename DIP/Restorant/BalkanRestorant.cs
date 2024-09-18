using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Restorant
{
    internal class BalkanRestorant
    {
        // Burada ki property'ler Concrete class'lara göbekten bagli
        // Dipendincy Inversion derki class'lar birbirine gobekten bagli olmasin . Gevsek bagli olsun.

        public Balik Balik { get; set; } = new Balik();
        public Tavuk Tavuk { get; set; } = new Tavuk();

        public void YemekYap()
        {
            Balik.BalikPisir();
            Tavuk.TavukPisir();
        }
    }
}
