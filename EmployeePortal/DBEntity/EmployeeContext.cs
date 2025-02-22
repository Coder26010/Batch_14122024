using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmployeePortal.DBEntity.Entity;

namespace EmployeePortal.DBEntity
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext():base("name=EMPDBCON")
        {
            
        }

        public DbSet<DEPARTMENTENTITY> Departments { get; set; }
    }
}