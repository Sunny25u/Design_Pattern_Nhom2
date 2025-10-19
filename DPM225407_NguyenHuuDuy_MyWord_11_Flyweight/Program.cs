using DPM225407_NguyenHuuDuy_MyWord_11_Flyweight;
class Program
{
    static void Main()
    {
        string text = "AABZB";
        var factory = new CharacterFactory();
        int size = 10;

        foreach (char c in text)
        {
            var character = factory.GetCharacter(c);
            character.Display(++size);
        }
    }
}
