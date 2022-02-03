using Oe.Generics.School.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oe.Generics.School.Core.Infrastructure
{
    public interface IRoomRepository
    {
        IList<Room> ListAll();
        Room GetById(Guid id);
        void Delete(Room room);
        void Update(Room room);
    }
}
