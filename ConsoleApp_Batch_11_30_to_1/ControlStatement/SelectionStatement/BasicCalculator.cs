using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ControlStatement.SelectionStatement
{
    internal class BasicCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("N1 : ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("N2 : ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            //define a lable for identification.
            OperatorSelection:
            Console.Write("Select Operator [+  -  *  /] : ");
            char _operator = Console.ReadKey().KeyChar;
            Console.WriteLine();

            //if (_operator == '+' )
            //    Console.WriteLine($"Result : {N1+N2}");
            //else if(_operator == '-' )
            //    Console.WriteLine($"Result : {N1 - N2}");
            //else if (_operator == '*')
            //    Console.WriteLine($"Result : {N1 * N2}");
            //else if (_operator == '/')
            //    Console.WriteLine($"Result : {N1 / N2}");
            //else
            //    Console.WriteLine("Opps! Invalid operator.");

            switch (_operator)
            {
                case '+':
                    Console.WriteLine($"Result : {N1 + N2}");
                    break;
                case '-':
                    Console.WriteLine($"Result : {N1 - N2}");
                    break;
                case '*':
                    Console.WriteLine($"Result : {N1 * N2}");
                    break;
                case '/':
                    Console.WriteLine($"Result : {N1 / N2}");
                    break;
                default:
                    Console.WriteLine("Opps! Invalid operator.");
                    goto OperatorSelection;
            }
        }
    }
}
