using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPG.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }

        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
  
        public string TypeUrlName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}