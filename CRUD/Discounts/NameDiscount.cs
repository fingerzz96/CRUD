using System.Collections.Generic;
using System.Linq;

namespace CRUD
{
    public class NameDiscount : Discount
    {
        public override double ReturnPrice(object items, object items2, object items3)
        {
            var orderItems = (List<Items>) items;
            var products = (List<Product>) items2;
            var orders = (List<Orders>) items3;
            var count = orders.Count;
            var cartTotalPrice = 0.0;
            var totalPrice = 0.0;

            foreach (var item in orderItems)
            {
                    var product = products.FirstOrDefault(p => p.Id == item.ProductId);
                    totalPrice = totalPrice + product.Price * item.Count;
                    cartTotalPrice = cartTotalPrice + totalPrice;
                    totalPrice = 0.0;
            }

            return cartTotalPrice * 0.5;
        }
    }
}