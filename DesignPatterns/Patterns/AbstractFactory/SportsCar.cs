using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class SportsCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving sports car...");
        }
    }
}
