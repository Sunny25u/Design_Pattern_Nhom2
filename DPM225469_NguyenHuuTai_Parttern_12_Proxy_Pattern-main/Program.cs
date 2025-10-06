using System;

namespace DPM225469_NguyenHuuTai_Parttern_12_Proxy_Game
{
    /// <summary>
    /// Proxy Pattern Demo trong Game
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            IGameCharacter warrior = new GameCharacterProxy("Warrior");
            IGameCharacter mage = new GameCharacterProxy("Mage");

            Console.WriteLine("\n--- Nhân vật chưa cần hiển thị, chưa load thật ---");

            Console.WriteLine("\n--- Khi cần hiển thị mới load nhân vật thật ---");
            warrior.Display();
            mage.Display();

            Console.WriteLine("\n--- Lần gọi tiếp theo không cần load lại ---");
            warrior.Display();
            mage.Display();

            Console.ReadKey();
        }
    }
}
