using DIP.Duzeltilmis.Abstract;
using DIP.Duzeltilmis.Concrete;

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
            Console.WriteLine("Hello, World!");
        }

        public static void Logla(ILogger logger, string message)
        {
            logger.Logla(message);
        }

    }
}
