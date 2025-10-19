using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_11_Flyweight
{
    abstract class Character
    {
        protected char symbol;
        public void Display(int size)
            => Console.WriteLine($"{symbol} (size {size})");
    }
    class CharacterA : Character { public CharacterA() => symbol = 'A'; }
    class CharacterB : Character { public CharacterB() => symbol = 'B'; }
    class CharacterZ : Character { public CharacterZ() => symbol = 'Z'; }
}
