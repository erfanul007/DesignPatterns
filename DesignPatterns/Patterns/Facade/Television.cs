using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade
{
    public class Television
    {
        public void PowerOn()
        {
            Console.WriteLine("Television Power turned on.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Television Power turned off.");
        }

        public void SelectInput(string inputType)
        {
            Console.WriteLine("Television media is running through " + inputType);
        }
    }
}
