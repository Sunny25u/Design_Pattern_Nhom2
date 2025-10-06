using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_Real_14_Command
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
