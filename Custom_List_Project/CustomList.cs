using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T> : IEnumerable<T>
    {
        //Member variables has a 
        private int count = 0;
        public int capacity;
        private T[] _items;
        public int Count => count;
        public int Capacity => capacity;
        private int location;
        public IEnumerator<T> Enumerator;

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
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> temp = new CustomList<T>();
            foreach (T item in listOne._items)
            {
                temp.Add(item);
            }
            foreach (T item in listTwo._items)
            {
                temp.Add(item);
            }
            return temp;
        }
        public override string ToString()
        {
            ////Get legnth of string
            //int stringLength = GetStringLenghth();
            ////create new string
            //string returnString

            //create new array of strings
            string[] arr = new string[capacity];/////////////////////////////////////////////////////////////////
            arr = NewStringArray();
            //GetCount
            // add all arr strings to one string
            
            int arrCount = arr.Length;
            Text newText = new Text();
            string returnString = newText.StringBuild(arr);
            return returnString;

            //System.Text.StringBuilder returnString = new System.Text.StringBuilder();
            //// Create a string of 1000 numbers from 0 to 999    
            //// separated by a comma and space    
            //for (int counter = 0; counter <= count; counter++)
            //{
            //    returnString.Append(arr[counter]);
                
            //}
            





        }
        private string[] NewStringArray()
        {
            string[] array = new string[capacity];
            for (int i = 0; i < capacity - 1; i++)
            {
                
                string itemsInArray = Convert.ToString(_items[i]);
                array[i] = itemsInArray;
                
            }
            return array;
        }
       



        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return _items.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_items).GetEnumerator();
        }
    }
}
//   if ((Convert.ToString(item)) == stringArray[i])
//{
//    return i;
//}
