using System;

class Program
{
    // Interface Implementation (nền tảng vẽ)
    interface IDrawAPI
    {
        void DrawCircle(int x, int y, int radius);
    }

    // Các implementation cụ thể
    class WindowsDrawAPI : IDrawAPI
    {
        public void DrawCircle(int x, int y, int radius)
        {
            Console.WriteLine($"Vẽ hình tròn trên Windows tại ({x},{y}) bán kính {radius}");
        }
    }

    class LinuxDrawAPI : IDrawAPI
    {
        public void DrawCircle(int x, int y, int radius)
        {
            Console.WriteLine($"Vẽ hình tròn trên Linux tại ({x},{y}) bán kính {radius}");
        }
    }

    // Abstraction (hình học)
    abstract class Shape
    {
        protected IDrawAPI drawAPI;

        protected Shape(IDrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public abstract void Draw();
    }

    // Refined Abstraction (hình tròn)
    class Circle : Shape
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, IDrawAPI drawAPI) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawAPI.DrawCircle(x, y, radius);
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Shape circle1 = new Circle(10, 20, 5, new WindowsDrawAPI());
        Shape circle2 = new Circle(15, 25, 10, new LinuxDrawAPI());

        circle1.Draw();
        circle2.Draw();
    }
}
