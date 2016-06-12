using ProjektPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPG.ViewModels
{
    public class ListMenuModel
    {
        public IEnumerable<ProductType> Types { get; set; }
    }

}