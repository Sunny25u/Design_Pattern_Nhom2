using DPM225407_NguyenHuuDuy_MyWord_18_Memento;
using static System.Console;
public class Program
{
    public static void Main()
    {
        // Init sales prospect through object initialization
        var s = new SalesProspect
        {
            Name = "Joel van Halen",
            Phone = "(412) 256-0990",
            Budget = 25000.0
        };
        // Store internal state
        var m = new ProspectMemory(s.SaveMemento());
        // Change originator
        s.Name = "Leo Welch";
        s.Phone = "(310) 209-7111";
        s.Budget = 1000000.0;
        // Restore saved state
        s.RestoreMemento(m.Memento);
        // Wait for user
        ReadKey();
    }
}

