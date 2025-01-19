using System;
using System.Collections.Generic;

namespace ConsoleApp_Batch_11_30_to_1.GenericExample
{
    internal class ListExample
    {
        //Named Function/ Named block
        //public static bool IsEven(int n)
        //{
        //    return (n % 2 == 0);
        //}
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            HashSet<int> list = new HashSet<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //list.RemoveAll(n => IsEven(n));
            //list.RemoveAll(n => n % 2 != 0); //lamda expression

            Console.WriteLine("Length : " + list.Count);
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }


        }
    }
}
