using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    internal class CityBike : IBike
    {
        public void Ride()
        {
            Console.WriteLine("Riding city bike for best milage..");
        }
    }
}
