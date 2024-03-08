using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter
{
    public class CarAdapter : ISmartCar
    {
        private readonly OldCar _vintageCar;
        public CarAdapter(OldCar oldCar)
        {
            _vintageCar = oldCar;
        }
        public void AutoStart()
        {
            Console.WriteLine("Verified owner and auto starting...");
            _vintageCar.PressToStart();
        }
    }
}
