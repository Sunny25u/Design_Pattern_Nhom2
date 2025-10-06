using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_17_SmartHome
{
    public class Fan : Device
    {
        public Fan(string name, ISmartHomeHub hub) : base(name, hub) { }
        public void TurnOn() => Console.WriteLine($"{Name}: Quạt bật.");
        public void TurnOff() => Console.WriteLine($"{Name}: Quạt tắt.");
    }

}
