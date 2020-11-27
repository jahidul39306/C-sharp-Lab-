using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    interface IMusicPlayer
    {
        void MusicSwitch(Boolean on);
        void Play(Boolean on);
        void SetVolume(int loudness);
        void PlayNext();
        void PlayPrevious();

    }
}
