using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.OOPS.Encapsulation
{
    class FullTimeEmployee : Employee
    {
        public int EmployeeAge
        {
            set { Age = value; }
            get { return Age; }
        }
    }

    public class Startup
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() {Name = "John", Gender = "Male"};
            //FullTimeEmployee employee = new FullTimeEmployee() { Name = "John", EmployeeAge = 10 };

            //employee.Name = "John";

            Console.WriteLine($"EmpId : {employee.EmpId}  Name : {employee.Name} Gender : {employee.Gender}");
        }
    }
}
