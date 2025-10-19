using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_11_Flyweight
{
    class CharacterFactory
    {
        private readonly Dictionary<char, Character> _chars = new();

        public Character GetCharacter(char key)
        {
            if (!_chars.ContainsKey(key))
            {
                _chars[key] = key switch
                {
                    'A' => new CharacterA(),
                    'B' => new CharacterB(),
                    'Z' => new CharacterZ(),
                    _ => throw new ArgumentException("Ký tự không hợp lệ")
                };
            }
            return _chars[key];
        }
    }
}
