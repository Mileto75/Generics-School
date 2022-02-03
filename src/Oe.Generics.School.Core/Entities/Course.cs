using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oe.Generics.School.Core.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
    }
}
