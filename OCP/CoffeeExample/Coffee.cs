using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.CoffeeExample
{
    public enum CoffeeType
    {
        TurkKahvesi=1,
        Latte,
        Capicino,
        Expresso,
        OsmanliKahvesi

    }
    public class Coffee
    {
        public double GetTotalPrice(int adet,CoffeeType coffeeType)
        {
            double price = 0;
            switch (coffeeType)
            {
                case CoffeeType.TurkKahvesi:
                    price += adet * 70;
                    break;
                case CoffeeType.Latte:
                    price += adet * 100;
                    break;
                case CoffeeType.Capicino:
                    price += adet * 120;
                    break;
                case CoffeeType.Expresso:
                    price += adet * 150;
                    break;
                case CoffeeType.OsmanliKahvesi:
                    price += adet * 150;
                    break;
                default:
                    break;
            }
            return price;
        }
    }
}