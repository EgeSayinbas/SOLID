using SRP.Entities;
using SRP.Ornek;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun() { UrunAdi = "Kalem" };
            UrunOlusturucu urunOlusturucu = new UrunOlusturucu();
            urunOlusturucu.UrunEkle(urun);
            Console.WriteLine("Hello, World!");
        }
    }
}