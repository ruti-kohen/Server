using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Matching;
using Newtonsoft.Json;
using Server.Entities.DTO;
using Server.Entities.Models;
using Server.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {

        ICandidateService _candidateService;
        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
       
      
        }
        // GET: api/<CandidateController>
        [HttpGet]
  


        public async Task<Candidate> Get()
        {
            //IEnumerable<Candidate> candidate = await _candidateService.GetCandidate();
            //IEnumerable<CandidateDTO> candidateDTOs = _mapper.Map<IEnumerable<Candidate>, IEnumerable<CandidateDTO>>(candidate);
            //return List<CandidateDTO>;

            var candidate = await _candidateService.GetCandidate();
            return candidate;
        }

        // GET api/<CandidateController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CandidateController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CandidateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CandidateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
