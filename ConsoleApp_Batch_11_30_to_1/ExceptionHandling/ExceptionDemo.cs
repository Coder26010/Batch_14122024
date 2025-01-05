using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ExceptionHandling
{
    internal class ExceptionDemo
    {
        public int Cal()
        {
            try
            {
                //con.open();
              
                Console.Write("N1 : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("N2 : ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;

                Console.WriteLine("Result : " + c);
                return c;
                //con.close();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Only numeric value allowed.");
                return 0;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Enter value between 0 and {int.MaxValue}");
                return 0;
            }
            catch (Exception ex)
            {
                //log the error in system

                Console.WriteLine("Currently system not able to process this request, try after some time.");
                return 0;
            }

            finally
            {
                Console.WriteLine("Completed!");
                //return 0;
                //code
            }
        }
        static void Main(string[] args)
        {
            //SqlConnection con = new SqlConnection(ConnectionString)
          
            int result = new ExceptionDemo().Cal();

            Console.WriteLine("Returned Value : " + result);

        }
    }
}
