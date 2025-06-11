using Application.EventOps.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Shared.EventOps.Dto;
using Shared.EventOps.Dto.Incident;
using Shared.EventOps.Result;
namespace API.EventOps.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class IncidentsController: ControllerBase
    {
        private readonly ILogger<IncidentsController> _logger;
        private readonly IIncidentService _incidentService;

        public IncidentsController(ILogger<IncidentsController> logger, IIncidentService incidentService)
        {
            _logger = logger;
            _incidentService = incidentService;
        }

        [HttpPost()]
        public async Task<IActionResult> CreateIncident([FromBody] IncidentRequest dto)
        {
            _logger.LogInformation("Creating incident: {@Incident}", dto);
            
            Result<string, string> result = await _incidentService.CreateIncident(dto);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            
            _logger.LogInformation("Incident created successfully with ID: {IncidentId}", result.Value);
            return Ok(result.Value);
        }
    }
}
