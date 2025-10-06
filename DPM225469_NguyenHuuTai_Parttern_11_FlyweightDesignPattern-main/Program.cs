using System;

namespace DPM225469_NguyenHuuTai_Parttern_11_FlyweightDesignNhanVat
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory factory = new CharacterFactory();

            GameCharacter c1 = factory.GetCharacter("Warrior");
            c1.Display(10, 20, 5, 100);

            GameCharacter c2 = factory.GetCharacter("Archer");
            c2.Display(15, 25, 3, 80);

            GameCharacter c3 = factory.GetCharacter("Mage");
            c3.Display(20, 30, 7, 60);

            GameCharacter c4 = factory.GetCharacter("Healer");
            c4.Display(25, 35, 4, 70);

            GameCharacter c5 = factory.GetCharacter("Assassin");
            c5.Display(30, 40, 6, 90);

            // Reuse Warrior
            GameCharacter c6 = factory.GetCharacter("Warrior");
            c6.Display(50, 60, 10, 200);

            Console.ReadKey();
        }
    }
}
