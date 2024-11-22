using Microsoft.AspNetCore.Mvc;
using HotelManager.Domain.Services.Room;
using HotelManager.Data.Component;
namespace LearnBack.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService _service;
        public RoomController(IRoomService service)
        {
            _service = service;
        }
        public RoomDto GetById(int id)
        {
            return _service.GetById(id);
        }
        public List<RoomDto> Get()
        {
            return _service.Get();
        }
        public void Update(RoomDto roomDto)
        {
            _service.Update(roomDto);
        }
        public void Delete(int id)
        {
            _service.Delete(id);
        }
        public void Create(RoomDto roomDto)
        {  
            _service.Create(roomDto);
        }
    }
}
