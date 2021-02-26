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
        private int capacity;
        private T[] _items;
        public int Count => count;
        public int Capacity => capacity;
        private int location;
        public IEnumerator<T> Enumerator;
        //private T[] _zipArray;

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
            int index = count - 1;
            _items[index] = item;

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

           
        }
        //remove method
        public void Remove(T item)
        {
            
            T[] tempArray = _items;
            int indexNumber = -1;

            FindIndexOfItem(item);

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
            int qty = listOne.Count + listOne.Count;
            T[] ti = new T[qty];
            temp._items = ti;
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

            string[] arr = new string[capacity];
            arr = NewStringArray();
            int arrCount = arr.Length;
            Text newText = new Text();
            string returnString = newText.StringBuild(arr);
            return returnString;
        }
        private string[] NewStringArray()
        {
            string[] array = new string[capacity];
            for (int i = 0; i <= capacity - 1; i++)
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


        public static CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> arr = new CustomList<T>();
            int listOneCount = listOne.Count;
            int listTwoCount = listTwo.Count;
            int listOneCounter = listOneCount;
            int listTwoCounter = listTwoCount;
            arr.Add(listOne[0]);
            listOneCount--;
            arr.Add(listTwo[0]);
            listTwoCount--;

            while (listOneCount != 0 && listTwoCount != 0)
            {
             
                arr.Add(listOne[listOneCounter]);
                listOneCount--;
                arr.Add(listTwo[listTwoCounter]);
                listTwoCount--;
            }
            if(listOneCount == 0 && listTwoCount != 0)
            {
                for(int i = 0; i < listTwoCount-1; i++)
                {
                    arr.Add(listTwo[listTwoCounter]);
                    
                }

                
            }
            if (listOneCount != 0 && listTwoCount == 0)
            {
                for (int i = 0; i < listOneCount-1; i++)
                {
                    arr.Add(listOne[listOneCounter]);
                    
                }
               

            }
            return arr;
            //public void Zip(CustomList<T> listOne, CustomList<T> listTwo)
            //{
            //    //set _items = items in both lists;
            //    int number = listOne.Count + listTwo.Count;

            //    capacity = number;
            //    T[] arr = new T[number];

            //    //get items in list one in 0,2,4... indeces


            //    int listOneQty = listOne.Count;
            //    int listOnei = (listOneQty * 2) - 2;
            //    int listOneIndex = 0;
            //    int listTwoQty = listTwo.Count;
            //    int listTwoi = (listTwoQty * 2) - 1;
            //    int listTwoIndex = 0;
            //    int listOneCountDown = listOneQty;
            //    int listTwoCountDown = listTwoQty;
            //    int iTracker = 0;
            //    while(listOneCountDown != 0 && listTwoCountDown != 0)
            //    {
            //        for (int i = 0; i <= listOnei; i += 2)
            //        {

            //        arr[i] = listOne[listOneIndex];
            //        listOneCountDown--;
            //        listOneIndex++;
            //        iTracker++;

            //    }

            //    //get items in list two in 0,2,4 etc

            //    for (int i = 1; i <= listTwoi; i += 2)
            //    {
            //        arr[i] = listTwo[0];
            //        listTwoCountDown--;
            //        listTwoIndex++;
            //        iTracker++;
            //    }

            //}
            //if(listOneCountDown > 0)
            //{

            //    for (int i = 0; i < listOneCountDown ; i++)
            //    {

            //        arr[iTracker] = listOne[listOneIndex];
            //        listOneCountDown--;
            //        listOneIndex++;
            //        iTracker++;

            //    }
            //}
            //if(listTwoCountDown > 0)
            //{

            //    for (int i = 0; i < listOneCountDown; i++)
            //    {

            //        arr[iTracker] = listTwo[listTwoIndex];
            //        listOneCountDown--;
            //        listTwoIndex++;
            //        iTracker++;

            //}


            //}
            //_items = arr;



        }





    }
}
