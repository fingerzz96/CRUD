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
        public const string DescriptionString = "description";

        public long Id { get; set; }
        public string Name { get; set; }
        public int CategoriesId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Product(long id, string name, int categoriesID, double price, string description)
        {
            Id = id;
            Name = name;
            CategoriesId = categoriesID;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Categories: {CategoriesId}," +
                   $" Price: {Price}, Description: {Description}";
        }
    }
}