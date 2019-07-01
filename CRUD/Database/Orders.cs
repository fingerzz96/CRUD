using System.Collections.Generic;

namespace CRUD
{
    public class Orders
    {
        public const string TableName = "Orders";
        public const string IdString = "ordersID";
        public const string CustomerIdString = "customerID";
        public const string PriceString = "price";
        public const string StateIdString = "stateID";

        public Orders() { }

        public Orders(long id, long customerId, double price, long stateId)
        {
            Id = id;
            CustomerId = customerId;
            Price = price;
            StateId = stateId;
        }

        public long Id { get; set; }
        public long CustomerId { get; set; }
        public double Price { get; set; }
        public long StateId { get; set; }

        public List<Items> Itemses { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, CustomerId: {CustomerId}, Price: {Price}, StateId: {StateId} ";
        }
    }
}