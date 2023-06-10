using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zasham.Shared.Model
{
    public class Customer
    {
        public string Customer_Name { get; set; }

        [Key]
        public string Customer_ID { get; set; }
  
        public string Customer_PhoneNumber { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_City { get; set;}
        public string Customer_Instructions { get; set; }

    }
}
