using Newtonsoft.Json;
using Server.Entities.Models;
using System.Net;
using System.Text.Json.Nodes;

namespace Server.Entities.Models
{
    public class MyApiResponse
    {
    //נסיון להזרת הנתונים כאובייקט 
        public List<Candidate> Candidates { get; set; }
        public List<Language> Languages { get; set; }
    }

    public class Candidate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BeginYear { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public List<int> Languages { get; set; }
        //public List<Language> Languages { get; set; }
    }

    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
