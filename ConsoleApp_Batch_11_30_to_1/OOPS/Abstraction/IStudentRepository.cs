using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.OOPS.Abstraction
{
    internal interface IStudentRepository
    {
        void Enroll(Student student);

        void DEnroll(int RollNo);

        void Update(int RollNo, Student student);

        void Remove(int RollNo);
    }
}
