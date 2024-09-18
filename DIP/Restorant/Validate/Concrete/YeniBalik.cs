using DIP.Restorant.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Restorant.Validate.Concrete
{
    internal class YeniBalik : IYemek
    {
        public void Pisir()
        {
            Console.WriteLine("Balik Pisti");
        }
    }
}
