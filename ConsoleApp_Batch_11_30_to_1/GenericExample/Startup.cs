using ConsoleApp_Batch_11_30_to_1.OOPS.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.GenericExample
{
    public class BasicCalculator
    {
        //Boxing
        //public void Add(object V1,object V2)
        //{
        //    //Unboxing
        //    dynamic Value1 = V1;
        //    dynamic Value2 = V2;
        //    Console.WriteLine("Sum : " + (Value1 + Value2));
        //}

        public void Add<T>(T V1, T V2)
        {
            //Unboxing
            //long N1 = Convert.ToInt64(V1);


            dynamic Value1 = V1;
            dynamic Value2 = V2;
            Console.WriteLine("Sum : " + (Value1 + Value2));
        }
    }
    internal class Startup
    {
        static void Main(string[] args)
        {
             FullTimeEmployee employee = new FullTimeEmployee();

            new BasicCalculator().Add("10.5F", "20");
        }
    }
}
