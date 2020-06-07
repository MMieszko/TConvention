namespace Client.Domain
{
    public sealed class Vehicle : IEntity
    {
        public long Id { get; }

        public Vehicle(long id)
        {
            this.Id = id;
        }
    }
}