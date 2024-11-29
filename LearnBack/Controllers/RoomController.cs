using Microsoft.AspNetCore.Mvc;
using HotelManager.Domain.Services.Room;
using HotelManager.Data.Component;
namespace LearnBack.Controllers
{
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _service;
        public RoomController(IRoomService service)
        {
            _service = service;
        }
        [HttpGet("GetById")]
        public RoomDto GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpGet("Get")]
        public List<RoomDto> Get()
        {
            return _service.Get();
        }
        [HttpPatch("Update")]
        public void Update(RoomDto roomDto)
        {
            _service.Update(roomDto);
        }
        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
        [HttpPost("Create")]
        public void Create(RoomDto roomDto)
        {
            _service.Create(roomDto);
        }
    }
}
