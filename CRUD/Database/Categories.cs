namespace CRUD
{
    public class Categories
    {
        public const string TableName = "Categories";
        public const string IdString = "categoriesID";
        public const string NameString = "name";

        public int Id { get; set; }
        public string Name { get; set; }

        public Categories(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}