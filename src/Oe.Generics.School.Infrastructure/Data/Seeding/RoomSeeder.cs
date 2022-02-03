using Microsoft.EntityFrameworkCore;
using Oe.Generics.School.Core.Entities;
using System;

namespace Oe.Generics.School.Infrastructure.Data.Seeding
{
    public class RoomSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                new Room { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "K.1.0.12", Capacity = 30 },
                new Room { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "U.2.0.02", Capacity = 40 },
                new Room { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "L.1.0.12", Capacity = 50 }
                );
        }
    }
}
