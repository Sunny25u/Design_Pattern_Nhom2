using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225480_DinhQuocThanh__Myword22_Template_Method
{
    public abstract class DataAccessor
    {
        public abstract void Connect();
        public abstract void Select();
        public abstract void Process(int count);
        public abstract void Disconnect();

        public void Run(int count)
        {
            Connect();
            Select();
            Process(count);
            Disconnect();
        }
    }
}
