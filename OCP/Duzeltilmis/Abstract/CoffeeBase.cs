using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Duzeltilmis.Abstract
{
    public abstract class CoffeeBase
    {
        double _price;
        public abstract double GetTotalPrice(int adet);
    }
}
