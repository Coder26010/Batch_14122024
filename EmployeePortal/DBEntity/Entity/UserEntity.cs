using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeePortal.DBEntity.Entity
{
    [Table("TUSER")]
    public class UserEntity
    {
        [Key]
        [Column("SystemNumber")]
        public int Id { get; set; }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}