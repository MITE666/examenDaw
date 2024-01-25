using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<ParticipantEvent> ParticipantEvents { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParticipantEvent>()
                .HasKey(pe => new { pe.ParticipantId, pe.EventId });

        }
    }
}