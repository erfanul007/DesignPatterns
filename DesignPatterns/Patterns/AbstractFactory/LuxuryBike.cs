using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class LuxuryBike : IBike
    {
        public void Ride()
        {
            Console.WriteLine("Riding luxury bike for looks and feel..");
        }
    }
}
