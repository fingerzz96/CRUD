using System.Collections.Generic;
using System.Linq;

namespace CRUD
{
    public class SpringDiscount : Discount
    {
        public override double ReturnPrice(object items, object items2, object items3)
        {
            List<Items> orderItems = (List<Items>) items;
            List<Product> products = (List<Product>) items2;
            double cartTotalPrice = 0.0;
            foreach (var item in orderItems)
            {
                double totalPrice = 0.0;
                var product = products.FirstOrDefault(p => p.Id == item.ProductId);

                if (item.Count >= 3 && item.Count < 8)
                {
                    totalPrice = totalPrice + (product.Price * 2) + ((product.Price * (item.Count - 2)) * 0.8);
                    cartTotalPrice += totalPrice;
                }

                if (item.Count >= 8 && item.Count < 12)
                {
                    totalPrice = totalPrice + (product.Price * 7) + ((product.Price * (item.Count - 7)) * 0.7);
                    cartTotalPrice += totalPrice;
                }

                if (item.Count >= 12)
                {
                    totalPrice = totalPrice + (product.Price * 7) + ((product.Price * (item.Count - 11)) * 0.6);
                    cartTotalPrice += totalPrice;
                }

                if (item.Count < 3)
                {
                    totalPrice = totalPrice + (product.Price * item.Count);
                    cartTotalPrice += totalPrice;
                }
            }

            return cartTotalPrice;
        }
    }
}