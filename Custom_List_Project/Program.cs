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
            list.Add(3);
            Console.WriteLine(list._items[0]);

            Console.ReadLine();
        }
    }
}
