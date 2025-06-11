using Shared.EventOps.Dto;
using Shared.EventOps.Dto.Incident;
using Shared.EventOps.Result;
namespace Application.EventOps.Interfaces
{
    public interface IIncidentService
    {
        public Task<Result<string, string>> CreateIncident(IncidentRequest incident);
        public Task<GridResponse<IncidentResponse>> GetIncidents(); // TODO: Define a DTO for IncidentResponse
    }
}
