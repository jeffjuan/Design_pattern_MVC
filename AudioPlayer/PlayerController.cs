using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class PlayerController : IController
    {
        private PlayerModel model;
        public IView view;

        public PlayerController(PlayerModel playerModel)
        {
            model = playerModel;
            view = new Form1(model, this);
        }

        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Play(int index)
        {
            model.Play(index);
        }

        public void Stop(int state)
        {
            model.Stop(state);
        }

        public void Next(int index)
        {
            model.Next(index);
        }

        public void Previous(int index)
        {
            model.Previous(index);
        }

        public void RandomPlay()
        {
            model.RandomPlay();
        }

        public void Cycle()
        {
            model.Cycle();
        }

        public double GetProgress()
        {
            return model.GetProgress();
        }

        public void CheckPlayerState()
        {
            model.CheckPlayerState();
        }

        /*
        public List<string> PlayList
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
         * */
    }
}