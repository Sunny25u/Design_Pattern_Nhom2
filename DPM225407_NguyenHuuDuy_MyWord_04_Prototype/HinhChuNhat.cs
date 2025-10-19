using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_04_Prototype
{
    class HinhChuNhat : IPrototype
    {
        public int Rong { get; set; }
        public int Dai { get; set; }

        public HinhChuNhat(int dai, int rong)
        {
            Dai = dai;
            Rong = rong;
        }

        public IPrototype Clone()
        {
            return new HinhChuNhat(Dai, Rong); // sao chép
        }

        public void HienThi()
        {
            Console.WriteLine($"Hình chữ nhật: Dài = {Dai}, Rộng = {Rong}");
        }
    }
}
