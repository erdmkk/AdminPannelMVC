using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User
    {
        [Key]
        public int id { get; set; }


        [StringLength(50)]
        public string name { get; set; }


        [StringLength(50)]
        public string surname { get; set; }


        [StringLength(50)]
        [EmailAddress]
        public string email { get; set; }


        [StringLength(10)]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
