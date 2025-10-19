using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_12_Proxy
{
    class MathProxy : IMath
    {
        private MathReal real = new();

        public double Add(double x, double y)
        {
            Console.WriteLine("→ Kiểm tra quyền truy cập...");
            var result = real.Add(x, y);
            Console.WriteLine("→ Ghi log thao tác.");
            return result;
        }
    }
}
