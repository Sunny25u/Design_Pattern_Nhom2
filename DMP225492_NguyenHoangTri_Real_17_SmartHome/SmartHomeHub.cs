using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP225492_NguyenHoangTri_Real_17_SmartHome
{
    public class SmartHomeHub : ISmartHomeHub
    {
        public Light light { get; set; }
        public Fan fan { get; set; }
        public Curtain curtain { get; set; }

        public void Notify(Device sender, string ev)
        {
            if (sender is LightSensor && ev == "Dark")
            {
                Console.WriteLine("Hub: Phát hiện trời tối -> Bật đèn, đóng rèm.");
                light.TurnOn();
                curtain.Close();
            }
            else if (sender is TempSensor && ev == "Hot")
            {
                Console.WriteLine("Hub: Nhiệt độ cao -> Bật quạt.");
                fan.TurnOn();
            }
            else if (sender is TempSensor && ev == "Cool")
            {
                Console.WriteLine("Hub: Nhiệt độ mát -> Tắt quạt.");
                fan.TurnOff();
            }
        }
    }
}
