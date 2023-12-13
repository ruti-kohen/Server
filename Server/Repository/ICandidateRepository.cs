

namespace Server.Repository
{
    public interface ICandidateRepository
    {

        Task<string> GetCandidate();
    }
}