using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class SportsBike : IBike
    {
        public void Ride()
        {
            Console.WriteLine("Riding sports bike for absolute speed...");
        }
    }
}
