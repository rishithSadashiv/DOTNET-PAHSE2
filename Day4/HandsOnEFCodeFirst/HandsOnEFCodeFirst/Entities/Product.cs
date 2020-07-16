using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

    [Table("company")]
    public class Company
    {
        [Key]
        public long id { get; set; }
        [Required]
        [StringLength(30)]
        [Column("cname")]
        public string company_name { get; set; }
        [Column("turnover")]
        public float turnover { get; set; }
        [Column("ceo")]
        public string ceo { get; set; }
        //more columns
       //Navigation properties
    }
