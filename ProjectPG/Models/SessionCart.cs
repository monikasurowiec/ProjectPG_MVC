using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ProjectPG.Models
{
    public class SessionCart// : ISessionCart
    {
        public Order order { get; set; }




        public SessionCart()
        {
            order = new Order() {
                orderId = Guid.NewGuid(),
                orderProduct = new List<OrderProduct>()
            };
        }
        public decimal SumTotalPrices()
        {
            decimal total = 0.0m;
            foreach (var item in order.orderProduct)
            {
                total += item.count * item.Product.productPrice;
            }
            return total;
        }


        public void ClearCart()
        {

        }

        public int AddProduct(int productId)
        {
            return AddProduct(new OrderProduct()
            {
                productId = productId,
                count = 1
            });

        }

        public int AddProduct(OrderProduct product)
        {
            product.orderId = this.order.orderId;

            bool productInList = false;
            int n = 0;
            foreach (var item in order.orderProduct)
            {
                if (item.productId == product.productId)
                {
                    productInList = true;
                    break;
                }
                n++;
            }

            if (productInList == true)
            {
                order.orderProduct[n].count += product.count;
                return 0;
            }
            else
            {
                order.orderProduct.Add(product);
                return 1;

            }

        }

        public void DeleteProduct(OrderProduct product)
        {
            bool productInList = false;
            int n = 0;
            foreach (var item in this.order.orderProduct)
            {
                if (item.productId == product.productId)
                {
                    productInList = true;
                    break;
                }
                n++;
            }
            if (productInList == true)
            {
                order.orderProduct.RemoveAt(n);
            }

        }


    }
}