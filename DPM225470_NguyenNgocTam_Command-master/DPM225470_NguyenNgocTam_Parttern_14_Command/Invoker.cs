using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_Parttern_14_Command
{
    public class Invoker
    {
        Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
