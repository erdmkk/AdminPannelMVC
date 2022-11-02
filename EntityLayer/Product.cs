using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product
    {
        [Key]
        public int id { get; set; }


        [StringLength(50)]
        public string name { get; set; }


        [StringLength(50)]
        public string description { get; set; }


        public int price { get; set; }


        public int stock { get; set; }
    }
}
