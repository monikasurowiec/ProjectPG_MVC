using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPG.Models
{
    public class OrderProduct
    {
        public int OrderProductId { get; set; }
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; } 
        

    }
}