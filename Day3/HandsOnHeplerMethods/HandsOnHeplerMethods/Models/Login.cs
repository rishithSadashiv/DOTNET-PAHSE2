using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnHeplerMethods.Models
{
    public class Login
    {
       [Required(ErrorMessage = "Username Required")]
        public string Uname { get; set; }
       [Required(ErrorMessage ="Password Required")]
       [RegularExpression("[a-z0-9]{8}",ErrorMessage ="Invalid Password")]
        public string Pwd { get; set; }
    }
}
