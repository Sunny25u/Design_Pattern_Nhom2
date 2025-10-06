using DPM225480_DinhQuocThanh_Pattern13_Chain_of_Responsibility;

public class Program
{
    public static void Main(string[] args)
    {
        // Setup Chain of Responsibility
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();
        Handler h3 = new ConcreteHandler3();
        h1.SetSuccessor(h2);
        h2.SetSuccessor(h3);
        // Generate and process request
        int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };
        foreach (int request in requests)
        {
            h1.HandleRequest(request);
        }
        // Wait for user
        Console.ReadKey();
    }
}