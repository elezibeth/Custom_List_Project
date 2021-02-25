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
            

            list[0] = 999999;
            Console.WriteLine(list[0]);


            Console.ReadLine();
        }
    }
}
