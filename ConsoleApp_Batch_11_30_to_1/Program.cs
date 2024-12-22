using System;
using System.CodeDom;

namespace ConsoleApp_Batch_11_30_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter Name : ");
            string Name = Console.ReadLine();

            Console.Write("Enter Age : ");
            int Age = Convert.ToInt32(Console.ReadLine());
            //int Age = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Name : " + Name + " Age : " + Age);

            Console.WriteLine("Name : {0} Age : {1}", Name, Age);

            Console.WriteLine($"Name : {Name}  Age : {Age}");

            //string datafromsource = null;
            ////Console.WriteLine(datafromsource+20);
            //Console.WriteLine(Convert.ToInt32(datafromsource) + 20);
            //Console.WriteLine(int.Parse(datafromsource) + 30);*/

            //\n \n \n 
            Console.WriteLine("calculator ");
            Console.WriteLine("enter two numbers : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Addition");

            Console.WriteLine(Num1 + Num2);

            Console.WriteLine("2. substration");

            Console.WriteLine(Num1 - Num2);

            Console.WriteLine("3.multiplication");

            Console.WriteLine(Num1 * Num2);

            Console.WriteLine("4.division");

            Console.WriteLine(Num1 - Num2);

            //Console.ReadKey();
        }
    }
}
