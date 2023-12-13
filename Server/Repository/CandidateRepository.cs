using Microsoft.AspNetCore.Routing.Matching;
using Newtonsoft.Json;
using Server.Entities.Models;
using System;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Server.Repository
{
    public class CandidateRepository : ICandidateRepository
    {
        private static List<Candidate> CandidateList = new List<Candidate>();
        string path = "M:\\פרקטיקום\\Server\\Server\\data.txt.txt";
        public async Task<string> GetCandidate()
        {

            //    if (CandidateList.Count == 0)
            //    {
            //        CandidateList.Add(new Candidate
            //        {
            //            Id = 1,
            //            Name = "Wolf",
            //            StartYear = new DateTime(2022 - 20 - 01),
            //            DateOfUpdatingTheCandidateInformation = new DateTime(2004, 5, 4),
            //            technologicalLanguages =
            //        });

            //     public int Id { get; set; }
            //public string Name { get; set; }
            //public DateTime? StartYear { get; set; }
            //public DateTime DateOfUpdatingTheCandidateInformation { get; set; }
            //public int TechnologicalLanguages { get; set; }
            //public virtual ICollection<TechnologicalLanguages> technologicalLanguages { get; set; } = new List<TechnologicalLanguages>();
        
            {
                {
                    try
                    {
                        var client = new HttpClient();
                        var response = await client.GetAsync("https://raw.githubusercontent.com/ozsoftware/canidates/main/db.json");
                        var conect = await response.Content.ReadAsStringAsync();
                     
                        // List<Candidate>con = JsonConvert.DeserializeObject<List<Candidate>>(conect);
                            return conect;
                    
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("Exception Hit------------");
                        Console.WriteLine(exception);
                        return null;
                    }
                }
            }

        }
    }
}