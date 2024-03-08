using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class EconomyVehicleFactory : IVehicleFactory
    {
        public IBike GetBike()
        {
            return new CityBike();
        }

        public ICar GetCar()
        {
            return new EconomyCar();
        }
    }
}
