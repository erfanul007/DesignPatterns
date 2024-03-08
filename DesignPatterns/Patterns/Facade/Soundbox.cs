using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade
{
    public class Soundbox
    {
        public void PowerOn()
        {
            Console.WriteLine("Soundbox power turned on.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Soundbox power turned off.");
        }

        public void SelectSource(string source)
        {
            Console.WriteLine("Audio output is playing from " + source);
        }

        public void SetVolumn(int target)
        {
            Console.WriteLine($"Volumn set to {target}");
        }
    }
}
