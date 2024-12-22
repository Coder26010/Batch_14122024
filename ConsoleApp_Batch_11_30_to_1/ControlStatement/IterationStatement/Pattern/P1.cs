using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ControlStatement.IterationStatement.Pattern
{
    internal class P1
    {
        /*
            *
            **
            ***
            ****
         */
        static void Main(string[] args)
        {
            //Console.WriteLine("   *");
            //Console.WriteLine("  ***");
            //Console.WriteLine(" *****");
            //Console.WriteLine("*******");

            int space = 3;
            int Star = 1;

            for (int i = 1; i <= 4; i++) 
            {
                for (int s = 1; s <= space; s++)
                {
                    Console.Write(" ");
                }

                for (int p = 1; p <= Star; p++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                space--;
                Star = Star + 2;
            }

            //for (int i = 1; i <= 4; i++)
            //{
            //    for(int p = 1; p <= i; p++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
