using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_17_SmartHome
{
    public abstract class Device
    {
        protected ISmartHomeHub hub;
        public string Name { get; private set; }

        public Device(string name, ISmartHomeHub hub)
        {
            this.Name = name;
            this.hub = hub;
        }
    }
}
