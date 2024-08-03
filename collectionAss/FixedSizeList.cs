using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionAss
{
    internal class FixedSizeList<T>
    {
        public int _count { get; set; }
        public T[] items { get; set; }
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new AggregateException($"can't make list of this capacity : {capacity}");
            }
            this._count = 0;
            this.items = new T[capacity];
        }
        public void Add(T item) 
        {
            if (_count >= items.Length)
            {
                throw new ArgumentException($"Can't add element array is full");
            }
            items[_count] = item;
            _count++;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return items[index];
        }
    }
}
