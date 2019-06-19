using System.Collections.Generic;
using System.Linq;

namespace CRUD
{
    public class AutumnDiscount : Discount
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
                totalPrice = totalPrice + product.Price * ItemDiscount(product) * item.Count;
                cartTotalPrice = cartTotalPrice + totalPrice;
            }

            return cartTotalPrice;
        }

        private double ItemDiscount(Product product)
        {
            double discount0 = 1;
            var discount5 = 0.95;
            var discount10 = 0.9;
            var discount15 = 0.85;
            var discount20 = 0.8;
            var discount25 = 0.75;

            switch (product.Name)
            {
                case "Cokolada":
                    return discount5;
                case "Smartphone":
                    return discount10;
                case "Deodorant":
                    return discount15;
                case "Mydlo":
                    return discount20;
                case "Chemie":
                    return discount25;
                default:
                    return discount0;
            }
        }
    }
}