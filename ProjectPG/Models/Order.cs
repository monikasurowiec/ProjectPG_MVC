using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPG.Models
{
    public class Order
    {
        public Guid orderId { get; set; }

        [StringLength(30)]
        public string firstName { get; set; }

        [StringLength(40)]
        public string lastName { get; set; }
       
        [StringLength(50)]
        public string postCode { get; set; } 
        public string city { get; set; }
        public string email { get; set; }
      
        public DateTime dataCreated { get; set; }
        public orderStatus orderStatus { get; set; }
        public decimal totalPrice { get; set; }
        public List<OrderProduct> orderProduct { get; set; }
    }

    public enum orderStatus
    {
        New,
        Ready
    }
}