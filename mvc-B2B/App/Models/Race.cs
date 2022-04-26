namespace App.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime EventDate { get; set; }
        public int FreePlaces { get; set; }
        public int MaxParticipants { get; set; }
        public int NumberParticipants { get; set; }
    }
}