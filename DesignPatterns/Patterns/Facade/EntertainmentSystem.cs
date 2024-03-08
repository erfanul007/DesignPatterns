using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Facade
{
    public class EntertainmentSystem
    {
        private readonly Television television;
        private readonly DVDPlayer dvdPlayer;
        private readonly Soundbox soundbox;
        private readonly MusicPlayer musicPlayer;

        public EntertainmentSystem(Television television, DVDPlayer dvdPlayer, Soundbox soundbox, MusicPlayer musicPlayer)
        {
            this.television = television;
            this.dvdPlayer = dvdPlayer;
            this.soundbox = soundbox;
            this.musicPlayer = musicPlayer;
        }

        public void PlayMovie()
        {
            television.PowerOn();
            soundbox.PowerOn();
            dvdPlayer.PowerOn();

            television.SelectInput("HDMI");
            
            soundbox.SelectSource("DVD");
            soundbox.SetVolumn(30);

            dvdPlayer.Play();
        }

        public void PlayMusic(string songName)
        {
            television.PowerOn();
            musicPlayer.PowerOn();
            soundbox.PowerOn();

            television.SelectInput("Bluetooth");

            soundbox.SelectSource("MusicPlayer");
            soundbox.SetVolumn(50);

            musicPlayer.SelectMusic(songName);
            musicPlayer.Play();
        }

        public void TurnOff()
        {
            television.PowerOff();
            musicPlayer.PowerOff();
            soundbox.PowerOff();
            dvdPlayer.PowerOff();
        }
    }
}
