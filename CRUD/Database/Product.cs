using System;

namespace CRUD
{
    public class Product
    {
        public const string TableName = "Product";
        public const string IdString = "productID";
        public const string NameString = "name";
        public const string CategoriesIdString = "categoriesID";
        public const string PriceString = "price";
        public const string DiscountString = "discount";
        public const string DescriptionString = "description";

        public long Id { get; set; }
        public string Name { get; set; }
        public string CategoriesId { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }

        public Product(long id, string name, string categoriesID, int price, int discount, string description)
        {
            Id = id;
            Name = name;
            CategoriesId = categoriesID;
            Price = price;
            Discount = discount;
            Description = description;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Categories: {CategoriesId}," +
                   $" Price: {Price}, Description: {Description}";
        }
    }
}