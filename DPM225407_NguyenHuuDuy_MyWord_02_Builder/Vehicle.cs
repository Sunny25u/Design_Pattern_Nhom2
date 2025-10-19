using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_02_Builder
{
    class Vehicle
    {
        private readonly Dictionary<string, string> parts = new();
        public string Type { get; }

        public Vehicle(string type) => Type = type;
        public string this[string key] { get => parts[key]; set => parts[key] = value; }

        public void Show()
        {
            Console.WriteLine($"\nVehicle Type: {Type}");
            foreach (var p in parts)
                Console.WriteLine($"{p.Key}: {p.Value}");
        }
    }

}
