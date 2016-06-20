using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPG.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public DateTime DataCreated { get; set; }
   
        public decimal TotalPrice { get; set; }
        public List<OrderProduct> OrderProduct { get; set; }
    }
}
    