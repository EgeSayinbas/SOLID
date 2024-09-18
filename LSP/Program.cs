using LSP.TelefonOrnegi;
using LSP.TelefonOrnegi.Validate;
using LSP.TelefonOrnegi.Validate.Concrete;

namespace LSP
{
    internal class Program
    {
        #region Konu Anlatimi
        /*
         * An object (such as a class) and a sub-object(such as a class that extends the first class) 
         * must be interchangeable without breaking the program
         * 
         * Kodlarımızda bir değişiklik yapmadan alt sınıfları, türedikleri sınıfların yerine kullanabilmeliyiz.

         * Eğer bir alt sınıf, bir üst sınıfın yerine geçebiliyorsa, 
         * bu alt sınıfın üst sınıfın kullandığı her metodu sağlaması ve bu metodların beklendiği şekilde çalışması gerekir. 
         * Ayrıca, bir sınıf abstract bir metodu içeriyorsa, bu sınıfın da abstract olması beklenir. 
         * Eğer bir sınıf abstract ise, doğrudan bir nesne örneği oluşturulamaz.
         * 
         * 
         * 
         */
        #endregion
        static void Main(string[] args)
        {
            // Bu ornekte nokia base siniftan gelen fotograf cekme metodunu kullanamadigindan dolayi 
            // LSP'ye aykiridir. Cunku ata sinifin yeteneklerini sergileyememistir.
            //BasePhone iphone = new Iphone();
            //Nokia3310 nokia = new Nokia3310();
            //nokia = iphone;
            //iphone = nokia;
            //iphone.TakePhoto();
            //nokia.TakePhoto();

            #region Validate 
            // Bu ornekte nokia ve iphone base siniftan gelen butun yetenekleri sergileyebilmektedir.
            // LSP'ye uygundur.
            NewBasePhone basephone = new NewBasePhone();
            basephone.Call();
            NewBasePhone newiphone = new NewIPhone();
            newiphone.Marka = "IPhone 50";
            NewBasePhone newnokia = new NewNokia3310();
            newiphone.Call();
            newnokia.Call();

            basephone = newiphone;
            newnokia = basephone;



            #endregion
            Console.WriteLine("Hello, World!");
        }
    }

    //internal abstract class BasePhone
    //{
    //    public void Call()
    //    {
    //        Console.WriteLine("Arama Yapildi..");
    //    }
    //    public abstract void TakePhoto();
    //}
}