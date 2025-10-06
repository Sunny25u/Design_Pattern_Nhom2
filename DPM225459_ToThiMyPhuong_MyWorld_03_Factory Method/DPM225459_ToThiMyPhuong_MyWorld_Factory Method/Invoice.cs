using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225459_ToThiMyPhuong_MyWorld_Factory_Method
{
    public abstract class Invoice
    {
        public List<Section> Sections { get; protected set; } = new List<Section>();
        public abstract void CreateSections();

        public override string ToString() => GetType().Name;
    }

}
