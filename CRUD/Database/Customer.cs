namespace CRUD
{
    public class Customer
    {
        public const string TableName = "Customer";
        public const string IdString = "customerID";
        public const string NameString = "name";
        public const string AddressString = "address";

        public Customer(long id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public Customer(string name)
        {
            Name = name;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString() { return $"Id: {Id}, Name: {Name}, Address: {Address}"; }
    }
}