using AutoMapper;
using Infrastructure.EventOps.Entities;
using Shared.EventOps.Dto.Incident;
namespace Application.EventOps.Profiles
{
    public class IncidentProfile: Profile
    {
        public IncidentProfile()
        {
            CreateMap<Incident, IncidentResponse>().ReverseMap();
        }
    }
}
