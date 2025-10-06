using DMP225492_NguyenHoangTri_Real_18_Memento_SoanThaoVb;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Originator originator = new Originator();
        History history = new History(originator);

        originator.SetState("A");
        history.Save();

        originator.SetState("AB");
        history.Save();

        originator.SetState("ABC");
        history.Save();

        Console.WriteLine("Trạng thái hiện tại: " + originator.State);

        history.Undo();
        Console.WriteLine("After Undo [<--]: " + originator.State);

        history.Undo();
        Console.WriteLine("After Undo [<--]: " + originator.State);

        history.Redo();
        Console.WriteLine("After Redo [-->]: " + originator.State);

        Console.ReadKey();
    }
}

