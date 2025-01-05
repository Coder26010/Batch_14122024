using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_Batch_11_30_to_1.OOPS.Encapsulation;

namespace Test
{
    class FullTimeEmployee : Employee
    {
        internal new string  Gender
        {
            get { return base.Gender; }
            set { base.Gender = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee employee = new FullTimeEmployee() { Name = "John", Gender = "Male" };
        }
    }
}
