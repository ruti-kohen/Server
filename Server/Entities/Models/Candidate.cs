using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Nodes;

namespace Server.Entities.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartYear { get; set; }
        public DateTime DateOfUpdatingTheCandidateInformation { get; set; }
  
        public TechnologicalLanguages[] LanguagesArr { get; set; }
        

    }
    public class TechnologicalLanguages
    {
        public int Id { get; set; }
        public string LanguagesName { get; set; }
    }
}
