using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPG.Models
{
    public class Product
    {
        public int productId { get; set; }
        public int productTypeId { get; set; }

        public string productName { get; set; }
        public string productUrlName { get; set; }
        
        public string productPictureName { get; set; }
        public string productDescription { get; set; }
        public int productCapacity { get; set; }

        public decimal productPrice { get; set; }
        public bool isCuttingPrice { get; set; }

        public bool noSeason { get; set; }

        public virtual ProductType productType { get; set; }
    }
}