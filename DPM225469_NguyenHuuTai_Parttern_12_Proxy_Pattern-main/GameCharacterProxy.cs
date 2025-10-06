using System;

namespace DPM225469_NguyenHuuTai_Parttern_12_Proxy_Game
{
    /// <summary>
    /// Proxy - chỉ load nhân vật khi cần
    /// </summary>
    public class GameCharacterProxy : IGameCharacter
    {
        private RealGameCharacter realCharacter;
        private string name;

        public GameCharacterProxy(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            // Lazy loading
            if (realCharacter == null)
            {
                realCharacter = new RealGameCharacter(name);
            }
            realCharacter.Display();
        }
    }
}
