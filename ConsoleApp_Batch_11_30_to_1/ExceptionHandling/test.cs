using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ExceptionHandling
{
    internal class test
    {
        public int Cals()
        {
            try
            {


                Console.Write("N1 : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("N2 : ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;

                Console.WriteLine("Result : " + c);
                return c;
                //con.close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error.");
                return 0;
            }
        }

        public int GetUserInput(int InputValue = 0)
        {
            int N1 = 0;
            bool IsValidInput = false;

            while (!IsValidInput)
            {
                try
                {
                    N1 = Convert.ToInt32(Console.ReadLine());

                    if (InputValue > 0)
                    {
                        if (InputValue == N1)
                            IsValidInput = true;
                    }
                    else
                    {
                        IsValidInput = true;
                    }
                }
                catch (Exception)
                {
                }
            }

            return N1;
        }
        static void Main(string[] args)
        {
            test ob = new test();

            Console.Write("N1 : ");
            int N1 = ob.GetUserInput(10);
            Console.Write("N2 : ");
            int N2 = ob.GetUserInput(20);

            Console.WriteLine("Sum : " + (N1 + N2));
        }
    }
}

