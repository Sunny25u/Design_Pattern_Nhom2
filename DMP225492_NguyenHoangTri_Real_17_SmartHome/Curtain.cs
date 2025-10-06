using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_17_SmartHome
{
    public class Curtain : Device
    {
        public Curtain(string name, ISmartHomeHub hub) : base(name, hub) { }
        public void Open() => Console.WriteLine($"{Name}: Rèm mở.");
        public void Close() => Console.WriteLine($"{Name}: Rèm đóng.");
    }
}
