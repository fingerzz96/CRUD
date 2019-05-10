namespace CRUD
{
    public class State
    {
        public const string TableName = "State";
        public const string IdString = "stateID";
        public const string NameString = "name";

        public long Id { get; set; }

        public string Name { get; set; }

        public State(long id, string name)
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