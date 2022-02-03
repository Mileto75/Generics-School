using Oe.Generics.School.Core.Entities;
using Oe.Generics.School.Core.Infrastructure;
using System;
using System.Collections.Generic;

namespace Oe.Generics.School.Core.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void Delete(Course course)
        {
            _courseRepository.Delete(course);
        }

        public Course GetById(Guid id)
        {
            return _courseRepository.GetById(id);
        }

        public IList<Course> ListAll()
        {
            return _courseRepository.ListAll();
        }

        public void Update(Course course)
        {
            _courseRepository.Update(course);
        }
    }
}
