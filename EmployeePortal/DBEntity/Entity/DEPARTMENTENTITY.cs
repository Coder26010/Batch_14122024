using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.DBEntity.Entity
{
    [Table("TDEPARTMENT")]
    public class DEPARTMENTENTITY
    {
        [Key]
        [Column("SystemNumber")]
        public int Id { get; set; }

        [Column("DCode")]
        public string DepartmentCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime RecordCreationDate { get; set; } = DateTime.Now;
    }
}