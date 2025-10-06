
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld_Interator
{
    public class ProductCollection : IProductCollection
    {
        private List<Product> _products = new List<Product>();

        public Product this[int index]
        {
            get => _products[index];
            set => _products.Add(value);
        }

        public int Count => _products.Count;

        public ProductIterator CreateIterator() => new ProductIterator(this);
    }

    // Iterator interface
    public interface IProductIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product CurrentItem { get; }
    }

}
