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
        private int count = 0;
        public int capacity;
        private T[] _items;
        public int Count => count;
        public int Capacity => capacity;
        private int location;
        private char[] _char;
        public T this[int i]
        {
            get { return _items[i]; }
            set { _items[i] = value; }
        }
    










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
            if (count == capacity)
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

            //public IEnumerator GetEnumerator() from lecture
            //{
            //    for(int i = 0; i < count; i++)
            //    {
            //        yield return 
            //    }
            //}
        }
        //remove method
        public void Remove(T item)
        {
            //find item in array to remove
            T[] tempArray = _items;
            

            //copy to temp array
            //convert to string for each loop on temp array, use case statements
           

            //if item matches item, return index number of array case 
            int indexNumber = -1;

            FindIndexOfItem(item);

            //store variable
            //temp array
            //copy from index zero to variable containing index # - 1;
            
            


            for (int i = 0; i <= (location - 1); i++)//rewrite indexer
            {
                tempArray[i] = _items[i];
            }

            for (int i = (location + 1); i <= (count - 1); i++)
            {
                tempArray[i - 1] = _items[i];
            }

            count = count - 1;

            _items = tempArray;


            // copy from index variable +1 to count -1;
            //_items = temp array



        }

        public void FindIndexOfItem(T item)//.Equals method... object method...
        {
            string[] stringArray = new string[capacity];
            for (int i = 0; i < count; i++)
            {
                string stringOne = Convert.ToString(_items[i]);
                stringArray[i] = stringOne;
            }
            string itemString = Convert.ToString(item);
            //first in last out
            for(int i = count; i >= 1; i--)
            {
                if(stringArray[i] == itemString)
                {
                    location = i;
                }
                
               
            }

          
            
        }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        //public IEnumerator<T> GetEnumerator()
        //{
        //    yeild return 
        //}
       
    }
}
//   if ((Convert.ToString(item)) == stringArray[i])
//{
//    return i;
//}
