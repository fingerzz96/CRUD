namespace CRUD
{
    public class Items
    {
        public const string TableName = "Items";
        public const string IdString = "itemsID";
        public const string OrderIdString = "orderID";
        public const string ProductIdString = "productID";
        public const string CountString = "count";
        public const string PriceString = "price";

        public long Id { get; set; }
        public long OrdersId { get; set; }
        public long ProductId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        public Items(long id, long ordersId, long productId, int count, int price)
        {
            Id = id;
            OrdersId = ordersId;
            ProductId = productId;
            Count = count;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id: {Id}, OrdersId: {OrdersId}, ProductId: {ProductId}," +
                   $" Count: {Count}, Price: {Price}";
        }
    }
}