using System;
using System.Collections.Generic;
using OCP.Ornek2.Duzeltilmis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Ornek2.Duzeltilmis.Concrete
{
    internal class DikDortgen : ISekil
    {

        public int KisaKenar { get; }
        public int UzunKenar { get; }
        public DikDortgen(int kisa, int uzun)
        {
            KisaKenar = kisa;
            UzunKenar = uzun;
        }
        public double AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

        public double CevreHesapla()
        {
            return (KisaKenar + UzunKenar) * 2;
        }
    }
}