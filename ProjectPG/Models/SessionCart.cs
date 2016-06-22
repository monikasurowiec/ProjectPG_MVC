using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ProjectPG.Models
{
    public class SessionCart : ISessionCart
    {
        public Order order { get; set; }


        public SessionCart()
        {
            order = new Order()
            {
                OrderId = Guid.NewGuid(),
                OrderProduct = new List<OrderProduct>()
            };
        }


        public decimal SumTotalPrices()
        {
            decimal total = 0.0m;
            foreach (var item in order.OrderProduct)
            {
                total += item.Count * item.Product.ProductPrice;
            }
            return total;
        }


        public int AddProduct(int productId)
        {
            return AddProduct(new OrderProduct()
            {
                ProductId = productId,
                Count = 1
            });
        }


        public int AddProduct(OrderProduct product)
        {
            product.OrderId = this.order.OrderId;

            bool productInList = false;
            int n = 0;
            foreach (var item in order.OrderProduct)
            {
                if (item.ProductId == product.ProductId)
                {
                    productInList = true;
                    break;
                }
                n++;
            }

            if (productInList == true)
            {
                order.OrderProduct[n].Count += product.Count;
                return 0;
            }
            else
            {
                order.OrderProduct.Add(product);
                return 1;
            }
        }


        public void DeleteProduct(OrderProduct product)
        {
            bool productInList = false;
            int n = 0;
            foreach (var item in this.order.OrderProduct)
            {
                if (item.ProductId == product.ProductId)
                {
                    productInList = true;
                    break;
                }
                n++;
            }
            if (productInList == true)
            {
                order.OrderProduct.RemoveAt(n);
            }
        }
    }
}