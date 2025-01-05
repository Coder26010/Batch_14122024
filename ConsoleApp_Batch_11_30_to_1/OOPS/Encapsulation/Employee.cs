using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_Batch_11_30_to_1.OOPS.Encapsulation
{
    public class Employee
    {
        //Data
        private int _EmpId;
        private string _Name;

        private int _Age;

        private string _Gender;

        private static int Count = 0;

        public Employee()
        {
            _EmpId = ++Count;
        }

      
        //Associated code
        public int EmpId
        {
            get { return _EmpId; }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
                {
                    _Name = value;
                }
                else
                {
                    throw new Exception("Name property can not be null or whitespace");
                }
            }
        }

        protected int Age
        {
            set { _Age = value; }
            get { return _Age; }
        }

        internal protected string Gender
        {
            set { _Gender = value; }
            get { return _Gender; }
        }

    }
}
