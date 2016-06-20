using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPG.Models
{  
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }

        public string ProductName { get; set; } 
        public string ProductPictureName { get; set; }
        public string ProductDescription { get; set; }

        public int ProductCapacity { get; set; }

        public decimal ProductPrice { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}