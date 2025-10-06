
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld_Interator
{
    public class ProductIterator : IProductIterator
    {
        private ProductCollection _collection;
        private int _current = 0;

        public ProductIterator(ProductCollection collection)
        {
            _collection = collection;
        }

        public Product First()
        {
            _current = 0;
            return _collection[_current];
        }

        public Product Next()
        {
            _current++;
            if (!IsDone)
                return _collection[_current];
            else
                return null;
        }

        public bool IsDone => _current >= _collection.Count;
        public Product CurrentItem => _collection[_current];
    }

}
