
using DPM225407_NguyenHuuDuy_MyWord_15_Interpreter;

class Program
{
    static void Main()
    {
        var tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

        string roman = "MCMXXVIII"; // 1928
        var context = new Context { Input = roman };

        foreach (var exp in tree)
            exp.Interpret(context);

        Console.WriteLine($"{roman} = {context.Output}");
        Console.ReadKey();
    }
}
