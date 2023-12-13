using AutoMapper;
using Server.Entities.DTO;
using Server.Entities.Models;

namespace Server
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Candidate, CandidateDTO>().ReverseMap();
        }
    }
}
