using System.Collections.Generic;

namespace DPM225469_NguyenHuuTai_Parttern_11_FlyweightDesignNhanVat
{
    // Flyweight Factory
    public class CharacterFactory
    {
        private readonly Dictionary<string, GameCharacter> _characters = new Dictionary<string, GameCharacter>();

        public GameCharacter GetCharacter(string type)
        {
            if (!_characters.ContainsKey(type))
            {
                switch (type)
                {
                    case "Warrior": _characters[type] = new ConcreteGameCharacter("Warrior", "Sword", "Slash"); break;
                    case "Archer": _characters[type] = new ConcreteGameCharacter("Archer", "Bow", "Multi Shot"); break;
                    case "Mage": _characters[type] = new ConcreteGameCharacter("Mage", "Staff", "Fireball"); break;
                    case "Healer": _characters[type] = new ConcreteGameCharacter("Healer", "Wand", "Heal"); break;
                    case "Assassin": _characters[type] = new ConcreteGameCharacter("Assassin", "Dagger", "Stealth"); break;
                }
            }
            return _characters[type];
        }
    }
}
