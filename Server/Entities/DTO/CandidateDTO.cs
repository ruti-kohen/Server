namespace Server.Entities.DTO
{
    public class CandidateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartYear { get; set; }
        public DateTime DateOfUpdatingTheCandidateInformation { get; set; }
    }
}
