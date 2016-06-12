using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPG.Models
{
    public class OrderProduct
    {
        public int orderProductId { get; set; }
        public Guid orderId { get; set; }
        public int productId { get; set; }
        public int count { get; set; }
        //public decimal productOrderPrice { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; } 
        

    }
}