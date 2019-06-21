using System.Collections.Generic;
using System.Linq;

namespace CRUD
{
    public class SpringDiscount : Discount
    {
        private double SpringDiscountMethod(double totalPrice, double productPrice, long itemCount,
                                            long itemBeforeDiscount, double percentageDiscount)
        {
            double priceBefore, priceAfter, priceDiscount, itemCountBeforeDisc;
            itemCountBeforeDisc = itemCount - itemBeforeDiscount;
            priceBefore = totalPrice + productPrice * itemBeforeDiscount;
            priceAfter = priceBefore + productPrice * itemCountBeforeDisc;
            priceDiscount = priceAfter * percentageDiscount;

            return priceDiscount;
        }

        public override double ReturnPrice(object items, object items2, object items3)
        {
            var orderItems = (List<Items>) items;
            var products = (List<Product>) items2;
            var cartTotalPrice = 0.0;
            foreach (var item in orderItems)
            {
                var totalPrice = 0.0;
                var product = products.FirstOrDefault(p => p.Id == item.ProductId);

                if (item.Count >= 3 && item.Count < 8)
                {
                    if (product != null)
                        totalPrice = SpringDiscountMethod(totalPrice, product.Price, item.Count, 2, 0.8);
                    cartTotalPrice += totalPrice;
                }

                if (item.Count >= 8 && item.Count < 12)
                {
                    if (product != null)
                        totalPrice = SpringDiscountMethod(totalPrice, product.Price, item.Count, 7, 0.7);
                    cartTotalPrice += totalPrice;
                }

                if (item.Count >= 12)
                {
                    //totalPrice = totalPrice + product.Price * 11 + product.Price * (item.Count - 11) * 0.6;
                    if (product != null)
                        totalPrice = SpringDiscountMethod(totalPrice, product.Price, item.Count, 11, 0.6);
                    cartTotalPrice += totalPrice;
                }

                if (item.Count < 3)
                {
                    totalPrice = totalPrice + product.Price * item.Count;
                    cartTotalPrice += totalPrice;
                }
            }

            return cartTotalPrice;
        }
    }
}