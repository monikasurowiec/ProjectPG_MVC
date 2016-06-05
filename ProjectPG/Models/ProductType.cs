using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektPG.Models
{
    public class ProductType
    {
        public int productTypeId { get; set; }
        public string typeName { get; set; }
        public string typeDescription { get; set; }
        public string typePicture { get; set; }

        public string typeUrlName { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}