using DPM225407_NguyenHuuDuy_Patterns_07_Bridge;
public class Program
{
    public static void Main(string[] args)
    {
        Abstraction ab = new RefinedAbstraction();
        // Set implementation and call
        ab.Implementor = new ConcreteImplementorA();
        ab.Operation();
        // Change implemention and call
        ab.Implementor = new ConcreteImplementorB();
        ab.Operation();
        // Wait for user
        Console.ReadKey();
    }
}
