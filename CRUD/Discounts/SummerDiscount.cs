using System.Collections.Generic;
using System.Linq;

namespace CRUD
{
    public class SummerDiscount : Discount
    {
        public override double ReturnPrice(object items, object items2, object items3)
        {
            var orderItems = (List<Items>) items;
            var products = (List<Product>) items2;
            var orders = (List<Orders>) items3;
            var count = orders.Count;
            var cartTotalPrice = 0.0;
            var totalPrice = 0.0;

            if (count >= 5 && count < 10)
            {
                foreach (var item in orderItems)
                {
                    var product = products.FirstOrDefault(p => p.Id == item.ProductId);
                    if (product != null) totalPrice = totalPrice + product.Price * item.Count;
                    cartTotalPrice += totalPrice;
                }

                return cartTotalPrice * 0.9;
            }

            if (count >= 10)
            {
                foreach (var item in orderItems)
                {
                    var product = products.FirstOrDefault(p => p.Id == item.ProductId);
                    if (product != null) totalPrice = totalPrice + product.Price * item.Count;
                    cartTotalPrice += totalPrice;
                }

                return cartTotalPrice * 0.8;
            }


            foreach (var item in orderItems)
            {
                var product = products.FirstOrDefault(p => p.Id == item.ProductId);
                if (product != null) totalPrice = totalPrice + product.Price * item.Count;
                cartTotalPrice += totalPrice;
            }

            return cartTotalPrice;
        }
    }
}