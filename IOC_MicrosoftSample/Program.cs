using Microsoft.Extensions.DependencyInjection;

namespace IOC_MicrosoftSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICollection<ServiceCollection> serviceDescriptors = new List<ServiceCollection>();
            ServiceCollection services = new ServiceCollection();

            services.AddKeyedTransient<ICar, Bmw>(Enum.GetName(CarType.Bmw));
            services.AddKeyedTransient<ICar, Ford>(Enum.GetName(CarType.Ford));
            services.AddKeyedTransient<ICar, Mercedes>(Enum.GetName(CarType.Mercedes));


            serviceDescriptors.Add(services);


            ServiceProvider contianer = services.BuildServiceProvider();


            var bmw = contianer.GetKeyedService<ICar>(Enum.GetName(CarType.Bmw));
            var bmw1 = contianer.GetKeyedService<ICar>(Enum.GetName(CarType.Bmw));
            var bmw2 = contianer.GetKeyedService<ICar>(Enum.GetName(CarType.Bmw));
            var bmw3 = contianer.GetKeyedService<ICar>(Enum.GetName(CarType.Bmw));


            Console.WriteLine(bmw.GetHashCode());
            Console.WriteLine(bmw1.GetHashCode());
            Console.WriteLine(bmw2.GetHashCode());
            Console.WriteLine(bmw3.GetHashCode());

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