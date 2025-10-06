using System;

namespace DPM225469_NguyenHuuTai_Parttern_12_Proxy_Game
{
    /// <summary>
    /// RealSubject - nhân vật thật sự, rất nặng để load
    /// </summary>
    public class RealGameCharacter : IGameCharacter
    {
        private string name;

        public RealGameCharacter(string name)
        {
            this.name = name;
            LoadFromDisk(); // giả lập tốn tài nguyên
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading character model [{name}] from disk...");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying character: {name}");
        }
    }
}
