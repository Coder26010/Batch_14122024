using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ControlStatement.IterationStatement
{
    internal class ForLoopDemo
    {
        static void Main(string[] args)
        {
            //for(int i = 9; i <= 10; i++)
            //{
            //    Console.WriteLine("Hello");
            //}

            // 1 or itself only
            // 2,3,4,5,6,7,8,9,10
            //Prime Number : 3 , 5 , 7 , 11

            //N1 = 10 => 20
            //N2 = 20 => 10
            //Output = 11,13,17,19


            int N = 15;
            bool IsPrime = true;

            for (int i = 2; i < N/2; i++)
            {
                Thread.Sleep(1000);
                if (N % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            if (IsPrime)
                Console.WriteLine("{0} is a prime number", N);
            else
                Console.WriteLine("{0} is not a prime number", N);

            //Console.Write("N1 : ");
            //int N1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("N1 : ");
            //int N2 = Convert.ToInt32(Console.ReadLine());

            ////int greater = (N1 > N2 ? N1 : N2);
            ////Console.WriteLine(greater);

            //for (int n = (N1 < N2 ? N1 : N2); n <= (N1 > N2 ? N1 : N2); n++)
            //{
            //    bool IsPrime = true;
            //    for (int i = 2; i < n; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            IsPrime = false;
            //        }
            //    }

            //    if (IsPrime)
            //        Console.Write(n + "\t");

            //}
            //Console.WriteLine();

        }
    }
}
