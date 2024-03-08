using DesignPatterns.Patterns.AbstractFactory;

namespace DesignPatterns.Demo
{
    public class AbstractFactoryDemo : IDesignPatternDemo
    {
        public void RunDemo()
        {
            Console.WriteLine("1. Economy");
            Console.WriteLine("2. Luxury");
            Console.WriteLine("3. Sports");
            Console.Write("Chose one: ");
            var input = Console.ReadLine();

            IVehicleFactory vehicleFactory = null;
            switch(input)
            {
                case "1":
                    vehicleFactory = new EconomyVehicleFactory();
                    break;
                case "2":
                    vehicleFactory = new LuxuryVehicleFactory();
                    break;
                case "3":
                    vehicleFactory = new SportsVehicleFactory();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }
            ICar car = vehicleFactory.GetCar();
            IBike bike = vehicleFactory.GetBike();

            car.Drive();
            bike.Ride();
        }
    }
}
