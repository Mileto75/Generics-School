using Microsoft.EntityFrameworkCore;
using Oe.Generics.School.Core.Entities;
using Oe.Generics.School.Infrastructure.Data.Seeding;

namespace Oe.Generics.School.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Course> Courses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Room)
                .WithMany(r => r.Courses);

            RoomSeeder.Seed(modelBuilder);
            CourseSeeder.Seed(modelBuilder);
        }
    }
}
