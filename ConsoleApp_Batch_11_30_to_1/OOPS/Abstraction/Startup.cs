using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.OOPS.Abstraction
{
    interface I1
    {
        void fun1();
    }

    interface I2
    {
        void fun1();
    }

    class Myclass : I1, I2
    {
        void I1.fun1()
        {
            Console.WriteLine("I1 Implementation");
        }

        void I2.fun1()
        {
            Console.WriteLine("I2 Implementation");
        }
    }
    internal class Startup
    {
        //private readonly IStudentRepository studentRepository;

        //public Startup(IStudentRepository repository)
        //{
        //    studentRepository = repository;
        //}
        static void Main(string[] args)
        {
            //Employee employee = new FullTimeEmployee();
            //IStudentRepository student = new IStudentRepository();
            I1 I1ref = new Myclass();

            I1ref.fun1();

            I2 I2ref = new Myclass();

            I2ref.fun1();

        }
    }
}
