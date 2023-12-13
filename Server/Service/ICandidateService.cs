using Server.Entities.Models;
namespace Server.Service;
public interface ICandidateService
{
    Task<Candidate> GetCandidate();
}