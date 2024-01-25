using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; } = "";

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public ICollection<ParticipantEvent> Participants { get; set; }
    }
}
