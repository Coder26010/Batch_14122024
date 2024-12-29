using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.OOPS.Polymorphism
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            Console.WriteLine();
            Console.WriteLine(10);
            Console.WriteLine(true);


            EmailService emailService = new EmailService();
        }
    }
}
