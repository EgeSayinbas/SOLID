using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Duzeltilmis.Abstract
{
    public interface ICoffee
    {
        ublic double Price { get; }
        public double GetTotalPrice(int adet);

    }
}
