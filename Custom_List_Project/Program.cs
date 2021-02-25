using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomList<int> list = new CustomList<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine(list._items[0]);
            Console.WriteLine(list._items[1]);
            Console.WriteLine(list._items[2]);
            Console.WriteLine(list._items[3]);
            Console.WriteLine(list._items[4]);



            list.Remove(3);
            Console.WriteLine(list._items[0]);
            Console.WriteLine(list._items[1]);
            Console.WriteLine(list._items[2]);
            Console.WriteLine(list._items[3]);


            Console.ReadLine();
        }
    }
}
