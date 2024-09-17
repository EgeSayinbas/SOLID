using OCP.CoffeeExample;
using OCP.CoffeExample;
using OCP.Duzeltilmis.Concrete;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Coffee coffee = new Coffee();
            double tutar = coffee.GetTotalPrice(2, CoffeeType.TurkKahvesi);

            TurkKahvesi turkKahvesi = new TurkKahvesi(70);
            turkKahvesi.GetTotalPrice(3);

            Console.WriteLine("Icilen Kahve Tutari:" + tutar);
            Console.WriteLine("Hello, World!");
        }
    }
}