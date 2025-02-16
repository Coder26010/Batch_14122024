using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.LINQExample
{
    public class Department
    {
        public int DepatId { get; set; }
        public string name { get; set; }
    }
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int DepatId { get; set; }
    }
    public class Demo
    {
        static void Main(string[] args)
        {

            //List<int> list = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35
            //};

            //Select col1,col2,col3... from TableName

            // from data in TableName select data

            //var allevennumbers = (from numbers in list
            //                      where numbers % 2 != 0
            //                      select numbers).ToList();

            //var allevennumbers = list.Where(x => x % 2 == 0).ToList();

            //foreach (var item in allevennumbers)
            //{
            //    Console.Write(item + "\t");
            //}

            List<Department> departments = new List<Department>()
            {
                new Department(){DepatId = 1,name = "IT"},
                new Department(){DepatId = 2,name = "HR"}
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){DepatId = 1,EmpId=1,Name="A"},
                new Employee(){DepatId = 1,EmpId=2,Name="B"},
                new Employee(){DepatId = 1,EmpId=3,Name="C"},
                new Employee(){DepatId = 2,EmpId=4,Name="D"},
                new Employee(){DepatId = 2,EmpId=5,Name="E"},
            };

            var employeesdata = (from emp in employees
                                 join dept in departments
                                 on emp.DepatId equals dept.DepatId
                                 where dept.name == "HR"
                                 select new
                                 {
                                     Name = emp.Name,
                                     Department = dept.name
                                 }
                                ).ToList();


            foreach (var item in employeesdata)
            {
                Console.WriteLine("Name : {0}  Department : {1}",item.Name,item.Department);
            }

        }
    }
}
