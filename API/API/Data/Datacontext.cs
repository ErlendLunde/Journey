using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Datacontext : DbContext
    {
        public DbSet<User> User{ get; set; } = null!;
        public DbSet<Journey> Journey { get; set; } = null!;
        public DbSet<UserJourney> UserJourneys { get; set; } = null!;
        public DbSet<DayTrip> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Journey;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserJourney>()
                .HasOne(uj => uj.User)
                .WithMany(u => u.UserJourneys)
                .HasForeignKey(uj => uj.UserId);

            modelBuilder.Entity<UserJourney>()
                .HasOne(uj => uj.Journey)
                .WithMany(j => j.UserJourneys)
                .HasForeignKey(uj => uj.JourneyId);
        }
    }
}
