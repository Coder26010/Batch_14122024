using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ControlStatement.SelectionStatement
{
    internal class IfDemonstration
    {
        static void Main(string[] args)
        {
            //Console.Write("Name : ");
            //string Name = Console.ReadLine();

            //Console.Write("Enter Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //if(Age > 18)
            //{
            //    //Lines of code
            //    Console.WriteLine("You are eligiable for futher processing.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligiable for futher processing.");
            //}


            Console.Write("N1 : ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("N2 : ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            if (N1 > N2)
                Console.WriteLine($"{N1} is greater.");
            else if(N2 > N1)
                Console.WriteLine($"{N2} is greater.");
            
        }
    }
}
