using Oe.Generics.School.Core.Entities;
using System;
using System.Collections.Generic;

namespace Oe.Generics.School.Core.Services
{
    public interface ICourseService
    {
        IList<Course> ListAll();
        Course GetById(Guid id);
        void Delete(Course course);
        void Update(Course course);
    }
}
