using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.Methods
{
    public class Student
    {
        public int RollNo;
        public string Name;
        public static int Count = 0;
        public Student()
        {
            Count++;
        }
    }
    internal class StaticAndInstanceMembers
    {
        static void Main(string[] args)
        {

            Student s1 = new Student()
            {
                RollNo = 1,
                Name = "John"
            };



            Student s2 = new Student()
            {
                RollNo = 2,
                Name = "ABC"
            };



            Student s3 = new Student()
            {
                RollNo = 3,
                Name = "XYZ"
            };



            //Console.WriteLine($"Roll No : {s3.RollNo}  Name : {s3.Name}");

            Console.WriteLine("Total Students : " + Student.Count);

            //Roll No. : 1 Name '~John'
            //Console.WriteLine("Roll No. : " + s3.RollNo + " Name : '~" + s3.Name + "'");
            //Console.WriteLine("Roll No. : {0}  Name : '~{1}'",s3.RollNo,s3.Name);

            //Console.WriteLine($"Roll No. {s3.RollNo} Name : '~{s3.Name}'");
        }
    }
}
