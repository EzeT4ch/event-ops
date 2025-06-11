namespace Infrastructure.EventOps.Entities
{
    public class Role: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual User User { get; set; }
    }
}
