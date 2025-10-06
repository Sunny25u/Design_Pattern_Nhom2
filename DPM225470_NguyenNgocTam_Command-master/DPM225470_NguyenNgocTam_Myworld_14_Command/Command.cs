using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225470_NguyenNgocTam_Myworld_14_Command
{
    public abstract class Command
    {
        protected TextDocument document;

        public Command(TextDocument document)
        {
            this.document = document;
        }

        public abstract void Execute();
        public abstract void Undo();
    }
}
