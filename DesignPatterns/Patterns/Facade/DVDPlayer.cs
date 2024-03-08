using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade
{
    public class DVDPlayer
    {
        public void PowerOn()
        {
            Console.WriteLine("DVD player power turned on.");
        }

        public void PowerOff()
        {
            Console.WriteLine("DVD player power turned off.");
        }

        public void Play()
        {
            Console.WriteLine("DVD player playing movie.");
        }

        public void Pause()
        {
            Console.WriteLine("DVD player paused movie.");
        }

        public void Stop()
        {
            Console.WriteLine("DVD player stop movie.");
        }

        public void Eject()
        {
            Console.WriteLine("DVD player CD ejected. Insert a new CD.");
        }
    }
}
