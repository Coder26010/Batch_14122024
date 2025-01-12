using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.CollectionDemo
{
    internal class JagedArrayDemo
    {
        static void Main(string[] args)
        {
            int[] PrimeNumbers = { 3, 5, 7, 11, 13 };
            int[] EvenNumbers = { 2, 4, 6, 8, 10 };
            int[] OddNumbers = { 1, 3, 5, 7, 9 };


            string[] SystemName = { "Prime Number", "Even Number", "Odd number" };
            int[][] NumbersSystem = new int[3][] { PrimeNumbers , EvenNumbers , OddNumbers };

           
            //NumbersSystem[0] = PrimeNumbers;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(SystemName[i]);
                Console.WriteLine("------------------------------------");

                for (int j = 0; j < NumbersSystem[i].Length; j++)
                {
                    Console.Write(NumbersSystem[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
