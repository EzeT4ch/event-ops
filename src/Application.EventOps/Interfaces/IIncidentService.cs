using Shared.EventOps.Dto;
using Shared.EventOps.Result;
namespace Application.EventOps.Interfaces
{
    public interface IIncidentService
    {
        public Task<Result<string, string>> CreateIncident(IncidentRequest incident);
        public Task<List<IncidentRequest>> GetIncidents(); // TODO: Define a DTO for IncidentResponse
    }
}
