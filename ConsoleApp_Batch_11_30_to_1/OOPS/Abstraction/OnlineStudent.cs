using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.OOPS.Abstraction
{
    internal class OnlineStudent : IStudentRepository
    {
        public void DEnroll(int RollNo)
        {
            throw new NotImplementedException();
        }

        public void Enroll(Student student)
        {
            throw new NotImplementedException();
        }

        public void Remove(int RollNo)
        {
            throw new NotImplementedException();
        }

        public void Update(int RollNo, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
