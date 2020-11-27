using System;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile m1 = new MusicFile("Music 1", "rakib", 2005, 360);
            MusicFile m2 = new MusicFile("Music 2", "sakib", 2007, 460);
            MusicFile m3 = new MusicFile("Music 3", "Robin", 2019, 600);
            MusicFile m4 = new MusicFile("Music 4", "rahim", 2020, 500);

            Phone p1 = new Phone();
            p1.AddMusicFile(m1, m2, m4);
            p1.SearchMusic(m2);
            p1.SearchMusic(m3);
            p1.AddMusicFile(m3);
            p1.SearchMusic(m3);
            m3.ChangeTitle("New Music");
            p1.SearchMusic(m3);

            p1.RadioSwitch(true);
            p1.Retune(89.25);
            p1.SetVolume(100);
            p1.ChangeChannel();
            p1.RadioSwitch(false);

            Console.WriteLine();

            p1.MusicSwitch(true);
            p1.Play(true);
            p1.SetVolume(65);
            p1.PlayNext();
            p1.PlayNext();
            p1.PlayPrevious();
            p1.Play(false);
            p1.MusicSwitch(false);
        }
    }
}
