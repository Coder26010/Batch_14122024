using ConsoleApp_Batch_11_30_to_1.OOPS.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.Delegates
{
    public delegate void myGroupDelegate();

    internal delegate bool IsValidMatch(FullTimeEmployee fullTimeEmployee);
    public class XYZ
    {
        public void Fun1()
        {
            Console.WriteLine("This is Fun1 Method of XYZ class");
        }

        public void Fun2()
        {
            Console.WriteLine("This is Fun2 Method of XYZ class");
        }
    }

    public class XYZ2
    {
        internal void GetEmployee(IsValidMatch isValidMatch)
        {
            List<FullTimeEmployee> fullTimeEmployees = new List<FullTimeEmployee>()
            {
                new FullTimeEmployee(){Name = "A",Gender = "M",Department="IT",Salary=88729},
                new FullTimeEmployee(){Name = "B",Gender = "M",Department="HR",Salary=88729},
                new FullTimeEmployee(){Name = "C",Gender = "M",Department="IT",Salary=5000078},
                new FullTimeEmployee(){Name = "D",Gender = "F",Department="AF",Salary=8748738},
                new FullTimeEmployee(){Name = "E",Gender = "M",Department="HR",Salary=56356536},
                new FullTimeEmployee(){Name = "F",Gender = "M",Department="IT",Salary=88729},
                new FullTimeEmployee(){Name = "G",Gender = "F",Department="IT",Salary=5365365},
            };

            foreach (var item in fullTimeEmployees)
            {
                if(isValidMatch.Invoke(item))
                Console.WriteLine("Id : {0} Name : {1} Gender : {2} Salary : {3} Department : {4}",
                    item.EmpId,item.Name,item.Gender,item.Salary,item.Department);
            }
        }
        public void Fun1()
        {
            Console.WriteLine("This is Fun1 Method of XYZ-2 class");
        }
    }
    internal class Startup
    {
        static void Main(string[] args)
        {
            
            XYZ obj = new XYZ();
            //obj.Fun1();
            //obj.Fun2();

            XYZ2 xYZ2 = new XYZ2();
            xYZ2.GetEmployee(x => x.Department != "IT" && x.Gender == "F");

            //Data type - ref => function Method - similar type
            myGroupDelegate groupDelegate = new myGroupDelegate(obj.Fun1);
            groupDelegate += obj.Fun2;
            groupDelegate += xYZ2.Fun1;

            //groupDelegate.Invoke();
        }
    }
}
