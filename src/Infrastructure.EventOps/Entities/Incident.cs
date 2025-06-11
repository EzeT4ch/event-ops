namespace Infrastructure.EventOps.Entities
{
    public class Incident: BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Severity { get; set; } // TODO: Define an enum for severity
        public string Ubication { get; set; } = string.Empty;
        public int Status { get; set; }
        public string? Ip { get; set; }
        public string? UserAgent { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
