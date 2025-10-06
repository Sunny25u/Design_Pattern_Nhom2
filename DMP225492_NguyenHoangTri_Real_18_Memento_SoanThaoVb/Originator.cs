using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_18_Memento_SoanThaoVb
{
    public class Originator
    {
        public string State { get; private set; }

        public void SetState(string state)
        {
            State = state;
            Console.WriteLine("Hiện tại: " + state);
        }

        public Memento SaveToMemento()
        {
            return new Memento(State);
        }

        public void RestoreFromMemento(Memento memento)
        {
            State = memento.State;
            Console.WriteLine("\nTrạng thái đã được khôi phục: " + State);
        }
    }
}
