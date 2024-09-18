using DIP.Restorant.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Restorant.Validate.Concrete
{
    internal class BorsaLokantasi
    {
        //IEnumarable yerine ICollection yazilabilir ICollection IEnumarable dan farklı olarak add remove clear gibi metodları vardır.
        private readonly IEnumerable<IYemek> Yemekler;
        
        public BorsaLokantasi(IEnumerable<IYemek> Yemekler)
        {
            this.Yemekler = Yemekler;
        }

        public void YemekYap()
        {
            foreach (var item in Yemekler)
            {
                item.Pisir();
            }
        }
    }

}
