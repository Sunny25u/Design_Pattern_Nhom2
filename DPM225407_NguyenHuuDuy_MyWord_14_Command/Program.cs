using DPM225407_NguyenHuuDuy_MyWord_14_Command;
class Program
{
    static void Main()
    {
        var user = new User();

        user.Compute('+', 100);
        user.Compute('-', 50);
        user.Compute('*', 10);
        user.Compute('/', 2);

        user.Undo(2);
        user.Redo(1);

        Console.ReadKey();
    }
}