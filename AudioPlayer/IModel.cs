using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public interface IModel
    {
        void RegisterView(IView v);

        void RemoveView(IView v);

        void NotifyVews();
    }
}