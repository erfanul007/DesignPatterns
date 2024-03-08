using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light turned off.");
        }
    }
}
