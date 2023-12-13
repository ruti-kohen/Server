using Newtonsoft.Json;
using Server.Entities.Models;
using Server.Repository;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        
        public async Task<Candidate>GetCandidate()
        {
            string response = await _candidateRepository.GetCandidate();
            // var res = JsonConvert.DeserializeObject<TechnologicalLanguages>(response);

       Candidate candidate = JsonConvert.DeserializeObject<Candidate> (response);

            return candidate;

        }
        //public async Task<List<User>> GetUsers()
        //{
        //    string response = await _usersRepository.GetUsers();
        //    List<User> users = JsonConvert.DeserializeObject<List<User>>(response);
        //    return users;


        //}
    }
}
