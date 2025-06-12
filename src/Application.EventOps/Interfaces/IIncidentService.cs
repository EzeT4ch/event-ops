using Shared.EventOps.Dto;
using Shared.EventOps.Dto.Incident;
using Shared.EventOps.Result;
namespace Application.EventOps.Interfaces
{
    public interface IIncidentService
    {
        public Result<string, string> CreateIncident(IncidentRequest incident);
        public GridResponse<IncidentResponse> GetIncidents();
    }
}
