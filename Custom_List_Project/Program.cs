﻿using System;
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
            //List<int> listJJ = new List<int>() { 1, 2, 3, 4, 5 };

            //foreach(int item in listJJ)
            //{
            //    Console.WriteLine(item);
            //}

            //CustomList<int> list = new CustomList<int>();
            //list.Add(0);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);


            //list[0] = 999999;
            //Console.WriteLine(list[0]);
            CustomList<char> list = new CustomList<char>();
            list.Add('h');
            Console.WriteLine(list[0]);


            Console.ReadLine();
        }
    }
}
