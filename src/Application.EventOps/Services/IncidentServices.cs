using Application.EventOps.Interfaces;
using Microsoft.Extensions.Logging;
using Shared.EventOps.Dto;
using Shared.EventOps.Dto.Incident;
using Shared.EventOps.Result;
namespace Application.EventOps.Services
{
    public class IncidentServices(
            ILogger<IncidentServices> _logger
        ): IIncidentService
    {
        public Task<Result<string, string>> CreateIncident(IncidentRequest incident)
        {
            throw new NotImplementedException();
        }

        public Task<GridResponse<IncidentResponse>> GetIncidents()
        {
            throw new NotImplementedException();
        }
    }
}
