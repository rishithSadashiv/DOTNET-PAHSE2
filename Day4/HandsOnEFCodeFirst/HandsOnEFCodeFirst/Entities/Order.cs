using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HandsOnEFCodeFirst.Entities
{
    class Order
    {
        //Scalar Properties
        [Key]
        [StringLength(5)]
        public string OId { get; set; }
        public DateTime OrderDate { get; set; }
        [ForeignKey("Product")]
        public int Pid { get; set; }
        //Navigation Property
        public Product Product { get; set; }

    }
}
