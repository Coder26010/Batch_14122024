using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ExtensionMethod
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            SmartCalculator calculator = new SmartCalculator();

            calculator.Add();
            calculator.Sub();
            calculator.Mul(10,20);

            
        }
    }
}
