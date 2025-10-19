using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_14_Command
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
