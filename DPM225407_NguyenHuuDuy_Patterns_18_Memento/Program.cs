using DPM225407_NguyenHuuDuy_Patterns_18_Memento;
public class Program
{
    public static void Main(string[] args)
    {
        Originator o = new Originator();
        o.State = "On";
        // Store internal state
        Caretaker c = new Caretaker();
        c.Memento = o.CreateMemento();
        // Continue changing originator
        o.State = "Off";
        // Restore saved state
        o.SetMemento(c.Memento);
        // Wait for user
        Console.ReadKey();
    }
}
