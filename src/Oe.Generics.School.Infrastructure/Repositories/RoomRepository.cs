using Microsoft.EntityFrameworkCore;
using Oe.Generics.School.Core.Entities;
using Oe.Generics.School.Core.Infrastructure;
using Oe.Generics.School.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Oe.Generics.School.Infrastructure.Repositories
{
    public class RoomRepository : EfRepository<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override Room GetById(Guid id)
        {
            return _dbContext.Rooms.Include(r => r.Courses).SingleOrDefault(r => r.Id.Equals(id));
        }

        public override IList<Room> ListAll()
        {
            return _dbContext.Rooms.Include(r => r.Courses).ToList();
        }
    }
}
