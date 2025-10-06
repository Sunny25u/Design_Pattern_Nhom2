using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld_Interator
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() => $"{Name} - {Price:C}";
    }

    // Aggregate interface
    public interface IProductCollection
    {
        ProductIterator CreateIterator();
    }

    // Concrete Aggregate
}
