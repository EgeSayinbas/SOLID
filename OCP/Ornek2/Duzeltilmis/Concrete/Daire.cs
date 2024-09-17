using System;
using OCP.Ornek2.Duzeltilmis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Ornek2.Duzeltilmis.Concrete
{
    internal class Daire : ISekil
    {
        public int YariCap { get; }
        public Daire(int yaricap)
        {
            YariCap = yaricap;
        }

        public double AlanHesapla()
        {
            throw new NotImplementedException();
        }

        public double CevreHesapla()
        {
            throw new NotImplementedException();
        }
    }
}