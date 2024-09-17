using OCP.Duzeltilmis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Duzeltilmis.Concrete
{
    public class Cay : ICoffee
    {
        public double Price { get; }
        public Cay(double price)
        {

            Price = price;
        }



        public double GetTotalPrice(int adet)
        {
            return adet * Price;
        }
    }
}
