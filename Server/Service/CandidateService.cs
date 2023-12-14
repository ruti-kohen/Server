using Newtonsoft.Json;
using Server.Entities.Models;
using Server.Repository;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Security.Principal;

namespace Server.Service
{
    public class CandidateService:ICandidateService
    {
        ICandidateRepository _candidateRepository;
        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }
        // public async Task<List<Candidate>> GetCandidate()
        public async Task<MyApiResponse> GetCandidate()
        {
            string response = await _candidateRepository.GetCandidate();
            var result = JsonConvert.DeserializeObject<MyApiResponse>(response);
            return result;
            var candidate = System.Text.Json.JsonSerializer.Deserialize<List<Candidate>>(response);
            //var candidate = response;//.Split(',');
            return null;

        }

    }
}
