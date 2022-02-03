using Oe.Generics.School.Core.Entities;
using Oe.Generics.School.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oe.Generics.School.Core.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public void Delete(Room room)
        {
            _roomRepository.Delete(room);
        }

        public Room GetById(Guid id)
        {
            return _roomRepository.GetById(id);
        }

        public IList<Room> ListAll()
        {
            return _roomRepository.ListAll();
        }

        public void Update(Room room)
        {
            _roomRepository.Update(room);
        }
    }
}
