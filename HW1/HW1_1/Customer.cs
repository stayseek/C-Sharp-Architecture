namespace HW1_1
{
    public class Customer : EntityBase
    {
        public string Description { get; set; }

        public Customer(IIdGenerator generator) : base (generator)
        {
            Description = string.Empty;
        }

        public Customer(string description, IIdGenerator generator) : base(generator)
        {
            Description = description;
        }
    }
}
