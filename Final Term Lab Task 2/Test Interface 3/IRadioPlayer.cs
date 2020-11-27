using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    interface IRadioPlayer
    {
        void RadioSwitch(Boolean on);
        void Retune(double frequency);
        void SetVolume(int loudness);
        void ChangeChannel();

    }
}
