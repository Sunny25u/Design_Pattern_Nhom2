using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_17_SmartHome
{
    public class TempSensor : Device
    {
        public TempSensor(string name, ISmartHomeHub hub) : base(name, hub) { }
        public void DetectHot()
        {
            Console.WriteLine($"{Name}: Phát hiện nhiệt độ cao.");
            hub.Notify(this, "Hot");
        }
        public void DetectCool()
        {
            Console.WriteLine($"{Name}: Phát hiện nhiệt độ mát.");
            hub.Notify(this, "Cool");
        }
    }
}
