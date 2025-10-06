using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_17_SmartHome
{
    public interface ISmartHomeHub
    {
        void Notify(Device sender, string ev);
    }
}
