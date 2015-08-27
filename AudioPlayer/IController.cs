using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public interface IController
    {
        string Title { get; set; }

        void Play(int index);

        void Stop(int state);

        void Next(int index);

        void Previous(int index);

        void RandomPlay();

        void Cycle();

        double GetProgress();

        void CheckPlayerState();

        //List<string> PlayList { get; set; }
    }
}