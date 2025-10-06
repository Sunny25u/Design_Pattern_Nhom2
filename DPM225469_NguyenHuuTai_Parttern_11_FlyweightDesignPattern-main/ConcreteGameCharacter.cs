using System;

namespace DPM225469_NguyenHuuTai_Parttern_11_FlyweightDesignNhanVat
{
    // ConcreteFlyweight
    public class ConcreteGameCharacter : GameCharacter
    {
        public ConcreteGameCharacter(string type, string weapon, string ability)
        {
            this.type = type;
            this.weapon = weapon;
            this.ability = ability;
        }

        public override void Display(int x, int y, int level, int hp)
        {
            Console.WriteLine($"[{type}] Weapon: {weapon}, Ability: {ability}, " +
                              $"Level: {level}, HP: {hp}, Position: ({x},{y})");
        }
    }
}
