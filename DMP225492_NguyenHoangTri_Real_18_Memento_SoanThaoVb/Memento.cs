using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_18_Memento_SoanThaoVb
{
    public class Memento
    {
        public string State { get; }
        public Memento(string state) { State = state; }
    }
}
