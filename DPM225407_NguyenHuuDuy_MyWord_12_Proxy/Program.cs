using DPM225407_NguyenHuuDuy_MyWord_12_Proxy;
class Program
{
    static void Main()
    {
        IMath proxy = new MathProxy();
        Console.WriteLine($"Kết quả: {proxy.Add(3, 5)}");
    }
}
