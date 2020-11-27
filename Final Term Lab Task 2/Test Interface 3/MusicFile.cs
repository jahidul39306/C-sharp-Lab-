using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    class MusicFile
    {
        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        private String artist;

        public String Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private int yearOfRelease;

        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }
        private int durationInSeconds;

        public int DurationInSeconds
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }
        public MusicFile()
        {
            Console.WriteLine("Empty Constructor");
        }
        public MusicFile(String title, String artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }
        public void ChangeTitle(String title)
        {
            this.title = title;
        }
        public void ShowMusicInfo()
        {
            Console.WriteLine("Music title: " + title);
            Console.WriteLine("Music artist: " + artist);
            Console.WriteLine("Release Year of this Music: " + yearOfRelease);
            Console.WriteLine("Duration in Seconds: " + durationInSeconds);
        }
    }
}
