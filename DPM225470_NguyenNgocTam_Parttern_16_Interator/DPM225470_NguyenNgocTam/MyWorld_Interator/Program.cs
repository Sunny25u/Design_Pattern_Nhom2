using MyWorld_Interator;

class Program
{
    static void Main(string[] args)
    {
        var products = new ProductCollection();
        products[0] = new Product("Laptop", 1200);
        products[1] = new Product("Phone", 800);
        products[2] = new Product("Headphones", 150);
        products[3] = new Product("Keyboard", 100);

        var iterator = products.CreateIterator();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Danh sách sản phẩm:");
        for (var p = iterator.First(); !iterator.IsDone; p = iterator.Next())
        {
            Console.WriteLine(p);
        }

        Console.ReadKey();
    }
}