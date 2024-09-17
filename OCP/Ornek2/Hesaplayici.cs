using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Ornek2
{
    internal class Hesaplayici
    {

        public double AlanHesapla(Daire daire)
        {
            return daire.YariCap * daire.YariCap * Math.PI;
        }

        public double AlanHesapla(DikDortgen dikDortgen)
        {
            return dikDortgen.KisaKenar * dikDortgen.UzunKenar;
        }


        public double AlanHesapla(DikUcgen dikUcgen)
        {
            return dikUcgen.KisaKenar * dikUcgen.UzunKenar / 2;
        }

        public double AlanHesapla(object sekil)
        {
            if (sekil is Daire)
            {
                return 0;
            }
            else if (sekil is DikDortgen)
            {
                return 0;
            }
            else if (sekil is DikUcgen)
            {
                return 0;
            }
            return 0;
        }


        public double CevreHesapla()
        {
            return 0;
        }
    }
}