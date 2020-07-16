using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCUsingEFCodeFirst.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [StringLength(5)]
        public string Eid { get; set; }
        [StringLength(30)]
        [Required]
        public string Ename { get; set; }
        public DateTime? JoinDate { get; set; }
        public int? Salary { get; set; }
    }
}
