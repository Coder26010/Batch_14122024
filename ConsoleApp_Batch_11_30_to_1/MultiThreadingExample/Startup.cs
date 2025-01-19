using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp_Batch_11_30_to_1.MultiThreadingExample
{
    public static class ThreadExampl
    {
        public static void PrintNumber()
        {
            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }

        public static void PrintString()
        {
            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Test - " + i);
            }
        }
    }

    internal class Startup
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadExampl.PrintNumber);
            Thread t2 = new Thread(ThreadExampl.PrintString);

            t1.Start();
            t2.Start();
            //ThreadExampl.PrintNumber();
            //ThreadExampl.PrintString();
            t1.Join();
            t2.Join();

            //Run by Main Thread...
            Console.WriteLine("Program Completed.");
        }
    }
}
