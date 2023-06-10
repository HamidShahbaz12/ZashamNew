using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zasham.Shared.Model
{
    public class Product
    {
        [Required]
       public string product_name { get; set; }
        [Key]
        public string product_id { get; set; }
        public string product_price { get; set; }
        public string product_description { get; set; }
       
        


    }
}
