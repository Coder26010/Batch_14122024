using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ControlStatement.IterationStatement
{
    internal class WhileLoopDemo
    {
        static void Main(string[] args)
        {
            //N1 = 123
            //Rev = 321 
            // N1 != Rev : 123 is not Palindrome

            //N1 = 121
            //Rev = 121
            //N1 = Rev : 121 is a palindrome number

            Console.Write("N1 : ");
            int N = Convert.ToInt32(Console.ReadLine()); //output : 4321
            int ActualValue = N;
            int Rev = 0;//4321

            while (N > 0)
            {
                int Reminder = N % 10;
                Rev = Rev * 10 + Reminder;
                N = N / 10;
            }

            Console.WriteLine("N1 : " + ActualValue);
            Console.WriteLine("Reverse : " + Rev);

            Console.WriteLine("--------------------------------");
            if(ActualValue == Rev)
                Console.WriteLine("{0} is a palindrome number",ActualValue);
            else
                Console.WriteLine("{0} is a not palindrome number", ActualValue);
        }
    }
}
 