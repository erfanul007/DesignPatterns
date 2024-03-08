using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter
{
    public class OldCar
    {
        private readonly string model;

        public OldCar(string model)
        {
            this.model = model;
        }

        public void PressToStart()
        {
            Console.WriteLine(this.model + " manually pressed to start.");
        }
    }
}
