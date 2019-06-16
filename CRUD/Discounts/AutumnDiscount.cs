using System.Collections.Generic;
using System.Linq;

namespace CRUD
{
    public class AutumnDiscount : Discount
    {
        public override double ReturnPrice(object items, object items2, object items3)
        {
            List<Items> orderItems = (List<Items>) items;
            List<Product> products = (List<Product>) items2;
            List<Orders> orders = (List<Orders>) items3;
            int count = orders.Count;
            double cartTotalPrice = 0.0;
            double totalPrice = 0.0;

            foreach (var item in orderItems)
            {
                var product = products.FirstOrDefault(p => p.Id == item.ProductId);
                totalPrice = totalPrice + ((product.Price * ItemDiscount(product)) * item.Count);
                cartTotalPrice = cartTotalPrice + totalPrice;
            }

            return cartTotalPrice;
        }

        private double ItemDiscount(Product product)
        {
            double discount0 = 1;
            double discount5 = 0.95;
            double discount10 = 0.9;
            double discount15 = 0.85;
            double discount20 = 0.8;
            double discount25 = 0.75;

            switch (product.Name)
            {
                case "Cokolada":
                    return discount5;
                case "Smartphone":
                    return discount10;
                case "Deodorant":
                    return discount15;
                case "":
                    return discount20;
                case "":
                    return discount25;
                default:
                    return discount0;
            }
        }
    }
}