using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.Methods
{
    public class SmartCalcultor
    {
      //access-specifiers  return-type  method-name([parameter list])
      //{ method block}

        //instance Method
        public int Sum(int x, int y)
        {
            //int sum = x + y;
            //return sum;

            return x + y;
        }

        public static void testStaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }
    }
    internal class MethodDemo
    {
        static void Main(string[] args)
        {
            SmartCalcultor smartCalcultor = new SmartCalcultor();

             int result =  smartCalcultor.Sum(10, 20);
            Console.WriteLine("Sum : " + result );


           SmartCalcultor.testStaticMethod();
        }
    }
}
