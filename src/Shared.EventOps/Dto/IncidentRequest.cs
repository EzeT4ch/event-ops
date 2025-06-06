namespace Shared.EventOps.Dto
{
    public class IncidentRequest
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public int Severity { get; set; } // TODO: Define an enum for severity
        public DateTime CreatedAt { get; set; }
        public int? Status { get; set; } // TODO: Define an enum for status
        public string? Ip { get; set; }
        public string? UserAgent { get; set; }
    }
}