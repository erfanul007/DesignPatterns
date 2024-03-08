using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class LuxuryVehicleFactory : IVehicleFactory
    {
        public IBike GetBike()
        {
            return new LuxuryBike();
        }

        public ICar GetCar()
        {
            return new LuxuryCar();
        }
    }
}
