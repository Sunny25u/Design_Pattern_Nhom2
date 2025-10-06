using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_17_Mediator
{
    public abstract class AbstractChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(
            string from, string to, string message);
    }
}
