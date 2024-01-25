using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantId { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; } = "";

        public ICollection<ParticipantEvent> Events { get; set; }
    }
}
