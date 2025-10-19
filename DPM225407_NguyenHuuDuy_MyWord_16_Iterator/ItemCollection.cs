using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225407_NguyenHuuDuy_MyWord_16_Iterator
{
    record Item(string Name);
    class ItemCollection : IEnumerable<Item>
    {
        
        private readonly List<Item> _items = new();

        public void Add(Item item) => _items.Add(item);
        public int Count => _items.Count;

        // Duyệt từ đầu đến cuối
        public IEnumerator<Item> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return _items[i];
        }

        // Duyệt ngược
        public IEnumerable<Item> Backward()
        {
            for (int i = Count - 1; i >= 0; i--)
                yield return _items[i];
        }

        // Duyệt theo khoảng và bước
        public IEnumerable<Item> RangeStep(int from, int to, int step)
        {
            for (int i = from; i <= to && i < Count; i += step)
                yield return _items[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
