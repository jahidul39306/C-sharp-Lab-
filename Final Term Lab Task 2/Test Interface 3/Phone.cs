using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    class Phone:IRadioPlayer, IMusicPlayer
    {
        MusicFile[] musicFiles = new MusicFile[500];
        int musicFileCount = 0;
        int playingNumber = 0;
        public void AddMusicFile(params MusicFile[] file)
        {
            foreach(var e in file)
            {
                if (musicFileCount < 500)
                {
                    Console.WriteLine("----------------------------");
                    musicFiles[musicFileCount++] = e;
                    Console.WriteLine(e.Title + " added successfully");
                    Console.WriteLine("Total Music: " + musicFileCount);
                    Console.WriteLine("----------------------------");
                }
                else Console.WriteLine("Storage Full, 500 music already added");
            }
        }
        public void SearchMusic(MusicFile file)
        {
            bool found = false;
            for (int i = 0; i < musicFileCount; i++)
            {
                if (musicFiles[i] == file)
                {
                    Console.WriteLine("----------------------------");
                    file.ShowMusicInfo();
                    found = true;
                    Console.WriteLine("----------------------------");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Music file not found");
                Console.WriteLine("----------------------------");
            }
        }

        public void RadioSwitch(Boolean on)
        {
            if (on) Console.WriteLine("Radio is playing");
            else Console.WriteLine("Radio is turned off");
        }
        public void Retune(double frequency)
        {
            Console.WriteLine("Changing to " + frequency);
        }
        public void SetVolume(int loudness)
        {
            Console.WriteLine("Volume is set to " + loudness);
        }
        public void ChangeChannel()
        {
            Console.WriteLine("Channel has been changed");
        }
        public void MusicSwitch(bool on)
        {
            if (on) Console.WriteLine("Music Player is turned on");
            else Console.WriteLine("Music Player is turned off");
        }
        public void Play(bool on)
        {
            if (on) Console.WriteLine(musicFiles[playingNumber].Title + " Music is playing");
            else Console.WriteLine("Music is turned off");
        }
        public void PlayNext()
        {
            playingNumber++;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Next music is starting...");
            Console.WriteLine(musicFiles[playingNumber].Title + " Music is Playing");
            Console.WriteLine("-------------------------------");
        }
        public void PlayPrevious()
        {
            playingNumber--;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Previous music is starting...");
            Console.WriteLine(musicFiles[playingNumber].Title + " Music is Playing");
            Console.WriteLine("-------------------------------"); 
        }

    }
}
