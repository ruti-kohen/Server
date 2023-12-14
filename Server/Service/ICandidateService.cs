using Server.Entities.Models;
namespace Server.Service;
public interface ICandidateService
{
    //Task<List<Candidate>> GetCandidate();
    Task<MyApiResponse> GetCandidate();
}
