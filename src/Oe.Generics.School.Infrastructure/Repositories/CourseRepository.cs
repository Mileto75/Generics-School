using Microsoft.EntityFrameworkCore;
using Oe.Generics.School.Core.Entities;
using Oe.Generics.School.Core.Infrastructure;
using Oe.Generics.School.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Oe.Generics.School.Infrastructure.Repositories
{
    public class CourseRepository : EfRepository<Course>, ICourseRepository
    {

        public CourseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override Course GetById(Guid id)
        {
            return _dbContext.Courses.Include(c=>c.Room).SingleOrDefault(c => c.Id.Equals(id));
        }

        public override IList<Course> ListAll()
        {
            return _dbContext.Courses.Include(c => c.Room).ToList();
        }
    }
}
