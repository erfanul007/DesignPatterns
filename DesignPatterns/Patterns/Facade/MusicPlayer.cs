using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade
{
    public class MusicPlayer
    {
        public void PowerOn()
        {
            Console.WriteLine("Music player power turned on.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Music player power turned off.");
        }

        public void Play()
        {
            Console.WriteLine("Music player playing music.");
        }

        public void Pause()
        {
            Console.WriteLine("Music player paused music.");
        }

        public void Stop()
        {
            Console.WriteLine("Music player stopped music.");
        }

        public void SelectMusic(string songName)
        {
            Console.WriteLine("Music player selected " + songName);
        }
    }
}
