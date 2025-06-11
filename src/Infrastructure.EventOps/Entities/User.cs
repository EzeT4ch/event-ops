namespace Infrastructure.EventOps.Entities
{
    public class User: BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Stamp { get; set; }

        public virtual ICollection<Role> Roles { get; set; } = [];
    }
}
