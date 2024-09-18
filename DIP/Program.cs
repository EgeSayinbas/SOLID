using DIP.Duzeltilmis.Abstract;
using DIP.Duzeltilmis.Concrete;
using DIP.Restorant.Validate.Abstract;
using DIP.Restorant.Validate.Concrete;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger filelogger = new YeniFileLogger();//YeniFileLogger filelogger = new YeniFileLogger();
            ILogger dblogger = new YeniDbLogger(); //YeniDbLogger db = new YeniDbLogger();
            Logla(filelogger, "klasdflkajdf");
            Logla(dblogger, "şlsdfşladkf");
            Tavuk tavuk= new Tavuk();
            YeniBalik yeniBalik = new YeniBalik();
           //queue sadece IEnumarable dan akdıgı icin add remove vb yapilamaz.(generic olarak yapilamaz)
            Queue<IYemek> pisirilecekler = new Queue<IYemek>();
            //HashSet<IYemek> pisirilecekler = new HashSet<IYemek>() { tavuk,yeniBalik };
            pisirilecekler.Enqueue(yeniBalik);
            pisirilecekler.Enqueue(tavuk);
            BorsaLokantasi borsaLokantasi = new BorsaLokantasi(pisirilecekler);
            Console.WriteLine("Hello, World!");
        }

        public static void Logla(ILogger logger, string message)
        {
            logger.Logla(message);
        }

    }
}
