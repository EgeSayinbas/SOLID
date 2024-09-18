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
        private readonly List<IYemek> Yemekler;

        public BorsaLokantasi(List<IYemek> Yemekler)
        {
            this.Yemekler = Yemekler;
        }

        public void YenekYap()
        {
            foreach (var item in Yemekler)
            {
                item.Pisir();
            }
        }
    }

}
