using Microsoft.EntityFrameworkCore;
using Oe.Generics.School.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oe.Generics.School.Infrastructure.Data.Seeding
{
    public class CourseSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "PIN", RoomId= Guid.Parse("00000000-0000-0000-0000-000000000001") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "PRI", RoomId = Guid.Parse("00000000-0000-0000-0000-000000000002") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "MDE", RoomId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "AIT", RoomId = Guid.Parse("00000000-0000-0000-0000-000000000001") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "WBA", RoomId = Guid.Parse("00000000-0000-0000-0000-000000000002") },
                new { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "PRA", RoomId = Guid.Parse("00000000-0000-0000-0000-000000000003") }
                );
        }
    }
}
