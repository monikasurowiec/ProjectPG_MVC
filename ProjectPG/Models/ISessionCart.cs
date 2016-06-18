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
        decimal SumTotalPrices(DiscountCode code);
        void ClearCart();
        int AddProduct(OrderProduct product);
    }
}
