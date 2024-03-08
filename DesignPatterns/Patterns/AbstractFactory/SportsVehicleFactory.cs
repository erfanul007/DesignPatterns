using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike GetBike()
        {
            return new SportsBike();
        }

        public ICar GetCar()
        {
            return new SportsCar();
        }
    }
}
