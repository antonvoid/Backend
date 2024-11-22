using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.Data.Component;
using HotelManager.Data.Repositories.Room;

namespace HotelManager.Domain.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _repository;
        public RoomService(IRoomRepository repository)
        {
            _repository = repository;
        }
        public RoomDto GetById(int id)
        {
            return _repository.GetById(id);
        }
        public List<RoomDto> Get()
        {
            return _repository.Get();
        }
        public void Update(RoomDto roomDto)
        {
            _repository.Update(roomDto);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        public void Create(RoomDto roomDto)
        {
            _repository.Create(roomDto);
        }
    }
}
