namespace DPM225469_NguyenHuuTai_Parttern_11_FlyweightDesignNhanVat
{
    // Flyweight (Abstract)
    public abstract class GameCharacter
    {
        protected string type;       // Intrinsic
        protected string weapon;     // Intrinsic
        protected string ability;    // Intrinsic

        public abstract void Display(int x, int y, int level, int hp); // Extrinsic
    }
}
