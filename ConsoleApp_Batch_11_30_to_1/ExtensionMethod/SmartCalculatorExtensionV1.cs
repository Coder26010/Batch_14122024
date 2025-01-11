using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ExtensionMethod
{
    internal static class SmartCalculatorExtensionV1
    {
        public static void Mul(this SmartCalculator cal, int V1, int V2)
        {
            Console.WriteLine("This is mutliplication method : " + (V1*V2));
        }

        public static void Div(this SmartCalculator c)
        {
            Console.WriteLine("This is Division method");
        }
    }
}
