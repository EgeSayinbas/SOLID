using OCP.Duzeltilmis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Duzeltilmis.Concrete
{
    public class TurkKahvesi : ICoffee
    {

        public double Price { get; }
        public TurkKahvesi(double price)
        {

            Price = price;
        }



        public double GetTotalPrice(int adet)
        {
            return adet * Price;
        }
    }
}
