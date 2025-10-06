using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_17_SmartHome
{
    public class LightSensor : Device
    {
        public LightSensor(string name, ISmartHomeHub hub) : base(name, hub) { }
        public void DetectDark()
        {
            Console.WriteLine($"{Name}: Phát hiện trời tối.");
            hub.Notify(this, "Dark");
        }
    }
}
