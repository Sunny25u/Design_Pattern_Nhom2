using DPM225407_NguyenHuuDuy_MyWord_16_Iterator;
public class Program
{
    static void Main()
    {

        var items = new ItemCollection();
        for (int i = 0; i < 9; i++)
            items.Add(new Item($"Item {i}"));

        Console.WriteLine("→ Front to back:");
        foreach (var item in items)
            Console.WriteLine(item.Name);

        Console.WriteLine("\n→ Back to front:");
        foreach (var item in items.Backward())
            Console.WriteLine(item.Name);

        Console.WriteLine("\n→ Range 1–7 step 2:");
        foreach (var item in items.RangeStep(1, 7, 2))
            Console.WriteLine(item.Name);

        Console.ReadKey();
    }
}