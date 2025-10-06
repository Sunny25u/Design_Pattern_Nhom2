using DPM225407_NguyenHuuDuy_Patterns_10_Facade;
public class Program
{
    public static void Main(string[] args)
    {
        Facade facade = new Facade();
        facade.MethodA();
        facade.MethodB();
        // Wait for user
        Console.ReadKey();
    }
}
