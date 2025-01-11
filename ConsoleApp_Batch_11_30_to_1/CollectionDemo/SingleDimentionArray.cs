using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.CollectionDemo
{
    internal class SingleDimentionArray
    {
        static void Main(string[] args)
        {
            int[] EvenNumbers = new int[5] {2,4,6,8,10};

            //2|4|6|8|10

            //EvenNumbers[0] = 2;
            //EvenNumbers[1] = 4;
            //EvenNumbers[2] = 6;
            //EvenNumbers[3] = 8;
            //EvenNumbers[4] = 10;

            Console.WriteLine(EvenNumbers.ConvertToString('|'));

            for (int i = 0; i < EvenNumbers.Length; i++)
            {
                Console.WriteLine(EvenNumbers[i]);
            }
        }
    }
}
