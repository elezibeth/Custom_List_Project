using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T>
    {
        //Member variables has a 
        public int count;
        public int capacity;
        public T[] _items;

        //CTOR is a
        public CustomList()
        {

            capacity = 4;
            _items = new T[capacity];
            count = _items.Length;//method get length

        }

        //Methods can do
        public void Add(T item)
        {
            
            if (count >= capacity)
            {
                int newCapacity = capacity * 2;
                T[] tempArray = new T[newCapacity];
                foreach (T iTem in _items)
                {
                    for (int i = 0; i <= count; i++)
                    {
                        tempArray[i] = _items[i];
                    }
                }
                _items = tempArray;
                capacity = newCapacity;
            }
            count = count++;
            _items[count] = item;

        }
    }
}
