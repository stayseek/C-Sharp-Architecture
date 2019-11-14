namespace HW1_1
{
    public abstract class EntityBase
    {
        public long Id { get; private set; }
        protected readonly IIdGenerator _generator;
   
        public EntityBase(IIdGenerator generator)
        {
            _generator = generator;
            Id = _generator.CalculateId();
        }
    }
}
