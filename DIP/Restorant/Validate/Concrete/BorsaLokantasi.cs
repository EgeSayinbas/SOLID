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
        private readonly IList<IYemek> Yemekler;

        public BorsaLokantasi(IList<IYemek> Yemekler)
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
