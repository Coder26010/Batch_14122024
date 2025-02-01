using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Models
{
    public class DepartmentModel
    {
        public int SystemNumber { get; set; }
        public string Dcode { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}