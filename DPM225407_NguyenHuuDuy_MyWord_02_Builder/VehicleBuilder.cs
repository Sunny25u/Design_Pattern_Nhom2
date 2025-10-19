using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_02_Builder
{
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        public Vehicle Vehicle => vehicle;
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
    }
}
