namespace API.Models
{
    public class ParticipantEvent
    {
        public int ParticipantId { get; set; }
        public int EventId { get; set; }
        public Participant Participant { get; set; }
        public Event Event { get; set; }
        public bool IsOrganizer { get; set; }
    }
}
