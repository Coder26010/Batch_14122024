using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ControlStatement.IterationStatement
{
    internal class doWhileLoop
    {
        static void Main(string[] args)
        {
            char UserChoice;
            do
            {
                Console.Write("N1 : ");
                int N1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("N2 : ");
                int N2 = Convert.ToInt32(Console.ReadLine());

            OperatorSelection:
                Console.Write("Select Operator [+  -  *  /] : ");
                char _operator = Console.ReadKey().KeyChar;
                Console.WriteLine();

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

                Console.WriteLine("To continue this program press 'y' : ");
                UserChoice = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (char.ToLower(UserChoice) == 'y');
        }
    }
}
