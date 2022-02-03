using System;
using System.Collections.Generic;

namespace Oe.Generics.School.Core.Entities
{
    public class Room : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Course> Courses { get; set; }
    }
}
