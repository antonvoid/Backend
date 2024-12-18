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
        public async Task<RoomDto> GetById(int id)
        {
            return await _service.GetById(id);
        }
        [HttpGet("Get")]
        public async Task<List<RoomDto>> Get()
        {
            return await _service.Get();
        }
        [HttpPatch("Update")]
        public async Task Update(RoomDto roomDto)
        {
            await _service.Update(roomDto);
        }
        [HttpDelete("Delete")]
        public async Task Delete(int id)
        {
            await _service.Delete(id);
        }
        [HttpPost("Create")]
        public async Task Create(RoomDto roomDto)
        {
            await _service.Create(roomDto);
        }
    }
}
