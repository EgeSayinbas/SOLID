using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace IOC_Sample4Unity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Standart Nesne olusumu
            //Bmw bmw = new Bmw();
            //Ford ford = new Ford();
            //Mercedes mercedes = new Mercedes();
            //Driver driver = new Driver(bmw);
            //driver.RunCar();
            //driver.RunCar();
            //driver.RunCar();
            //driver.RunCar();
            #endregion

            #region Standart Unity Kullanimi
            IUnityContainer container = new UnityContainer();
            //Container'a class'larin register edilmesi

            container.RegisterType<ICar, Bmw>(Enum.GetName(CarType.Bmw));
            container.RegisterType<ICar, Ford>(Enum.GetName(CarType.Ford));
            container.RegisterType<ICar, Mercedes>(Enum.GetName(CarType.Mercedes));
            // Container'dan nesneyi geri almak
            var bmw = container.Resolve<ICar>(Enum.GetName(CarType.Bmw));
            bmw.Run();


            //Constructer kullanimi

            container.RegisterType<Driver>("BmwSurucu", new InjectionConstructor(bmw));
            //Resolve edilmesi
            var surucu = container.Resolve<Driver>("BmwSurucu");
            surucu.RunCar();
            surucu.RunCar();
            surucu.RunCar();
            surucu.RunCar();
            surucu.RunCar();
            surucu.RunCar();
            surucu.RunCar();

            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
    public enum CarType
    {
        Bmw = 1, Ford = 2, Mercedes = 3
    }

    public interface ICar
    {
        int Run();
    }
    public class Driver
    {
        private readonly ICar car;

        public Driver(ICar car)
        {

            this.car = car;
        }
        public void RunCar()
        {
            Console.WriteLine($"{car.GetType().Name} => {car.Run()} km hizla gidiyor");
        }
    }

    public class Bmw : ICar
    {
        int km = 0;
        public int Run()
        {
            return ++km;
        }
    }
    public class Ford : ICar
    {
        int km = 0;
        public int Run()
        {
            return ++km;
        }
    }
    public class Mercedes : ICar
    {
        int km = 0;
        public int Run()
        {
            return ++km;
        }
    }
}