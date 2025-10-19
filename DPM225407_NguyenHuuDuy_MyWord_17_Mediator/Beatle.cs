using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DPM225407_NguyenHuuDuy_MyWord_17_Mediator
{
    public class Beatle : Participant
    {
        public override void Receive(string from, string message)
        {
            Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}
