using Oe.Generics.School.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oe.Generics.School.Core.Infrastructure
{
    public interface ICourseRepository
    {
        IList<Course> ListAll();
        Course GetById(Guid id);
        void Delete(Course course);
        void Update(Course course);
    }
}
