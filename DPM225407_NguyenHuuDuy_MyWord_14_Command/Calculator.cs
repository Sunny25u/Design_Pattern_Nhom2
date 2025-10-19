using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_14_Command
{
    class Calculator
    {
        private int _current = 0;

        public void Operation(char op, int num)
        {
            _current = op switch
            {
                '+' => _current + num,
                '-' => _current - num,
                '*' => _current * num,
                '/' => _current / num,
                _ => _current
            };
            Console.WriteLine($"Current value = {_current,3} (after {op} {num})");
        }
    }
}
