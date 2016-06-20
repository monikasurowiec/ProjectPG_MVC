using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPG.Models
{
    public interface ISessionCart
    {
        decimal SumTotalPrices();
        int AddProduct(int productId);
        int AddProduct(OrderProduct product);
        void DeleteProduct(OrderProduct product);
    }
}
