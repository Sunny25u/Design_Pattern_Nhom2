using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_17_Mediator
{
    public class Chatroom : IChatroom
    {
        private readonly Dictionary<string, Participant> participants = [];
        public void Register(Participant participant)
        {
            participants.TryAdd(participant.Name, participant);
            participant.Chatroom = this;
        }
        public void Send(string from, string to, string message)
        {
            var participant = participants[to];
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
