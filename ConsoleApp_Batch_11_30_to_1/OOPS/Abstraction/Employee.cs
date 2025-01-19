using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.OOPS.Abstraction
{
   abstract internal class Employee
    {
        //Common Code
        private static int identity = 0;
        protected Employee()
        {
            EmpId = ++identity;
        }
        public int EmpId { get;}
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public abstract float GetProductiveHoiurs();

        public void AllocateToProject(int EmpId)
        {
            //code
        }
    }
}
