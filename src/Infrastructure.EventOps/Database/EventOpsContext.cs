using Microsoft.EntityFrameworkCore;
namespace Infrastructure.EventOps.Database
{
    public class EventOpsContext: DbContext
    {
        public EventOpsContext(DbContextOptions<EventOpsContext> options) : base(options)
        {
        }
        
        public DbSet<Entities.Incident> Incidents { get; set; }
        public DbSet<Entities.Role> Roles { get; set; }
        public DbSet<Entities.User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Configure entities
            modelBuilder.Entity<Entities.Incident>().ToTable("Incidents");
            modelBuilder.Entity<Entities.Role>().ToTable("Roles");
            modelBuilder.Entity<Entities.User>().ToTable("Users").HasMany(x => x.Roles);

            // Add any additional configurations here
        }
    }
}
