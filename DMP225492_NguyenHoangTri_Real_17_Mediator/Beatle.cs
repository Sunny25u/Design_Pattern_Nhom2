using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_17_Mediator
{
    public class Beatle : Participant
    {
        // Constructor
        public Beatle(string name)
            : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }

}
