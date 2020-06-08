namespace Client.Domain
{
    public class User : IEntity
    {
        public long Id { get; }

        public User(long id)
        {
            this.Id = id;
        }
    }
}