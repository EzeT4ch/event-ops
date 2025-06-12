using Application.EventOps.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Shared.EventOps.Dto;
using Shared.EventOps.Dto.Incident;
using Shared.EventOps.Result;
using Infrastructure.EventOps.Interfaces;
using Infrastructure.EventOps.Entities;

namespace Application.EventOps.Services
{
    public class IncidentServices(
            ILogger<IncidentServices> _logger, IRepository<Incident> _incidentRepository, IMapper _mapper
        ): IIncidentService
    {
        public Result<string, string> CreateIncident(IncidentRequest incident)
        {
            throw new NotImplementedException();
        }

        public GridResponse<IncidentResponse> GetIncidents()
        {
            GridResponse<IncidentResponse> response = new();
            
            List<Incident> incidents = _incidentRepository.GetAll();
            
            response.Data = _mapper.Map<List<IncidentResponse>>(incidents);
            
            response.TotalCount = response.Data.Count;
            return response;
        }
    }
}
