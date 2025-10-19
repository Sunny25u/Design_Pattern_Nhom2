using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_02_Builder
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder() => vehicle = new Vehicle("Car");
        public override void BuildFrame() => vehicle["Frame"] = "Car Frame";
        public override void BuildEngine() => vehicle["Engine"] = "2500 cc";
        public override void BuildWheels() => vehicle["Wheels"] = "4";
    }
}
