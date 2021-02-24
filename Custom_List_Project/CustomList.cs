using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T> where T : struct
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
            count = 0;

        }

        //Methods can do
        public void Add(T item)
        {

            ResizeArray();
            count = count + 1;
            _items[count - 1] = item;

        }
        public void ResizeArray()
        {
            if (count >= capacity)
            {
                int newCapacity = capacity * 2;
                T[] tempArray = new T[newCapacity];


                for (int i = 0; i <= (count - 1); i++)
                {
                    tempArray[i] = _items[i];
                }

                _items = tempArray;
                capacity = newCapacity;
            }
        }
    }
}
