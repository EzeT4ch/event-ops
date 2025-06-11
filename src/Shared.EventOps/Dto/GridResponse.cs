namespace Shared.EventOps.Dto
{
    public class GridResponse<T> where T : class
    {
        public List<T> Data { get; set; } = [];
        public int TotalCount { get; set; }
    }
}
