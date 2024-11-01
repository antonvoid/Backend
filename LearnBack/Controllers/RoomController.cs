using Microsoft.AspNetCore.Mvc;
using LearnBack.Component;
namespace LearnBack.Controllers
{
    public class RoomController : Controller
    {
        private List<RoomDto> roomDtos = new List<RoomDto>
            {
                new RoomDto { Id = 0, Number = 0 },
                new RoomDto { Id = 1, Number = 1 },
                new RoomDto { Id = 2, Number = 2 },
                new RoomDto { Id = 3, Number = 3 },
                new RoomDto { Id = 4, Number = 4 }
            };

        public RoomDto GetById(int id)
        {
            if (roomDtos != null)
            {
                foreach (RoomDto roomDto in roomDtos)
                {
                    if (roomDto.Id == id)
                    {
                        return roomDto;
                    }
                }
                throw new Exception($"Элемент с id:{id} не найден");
            }
            else
            {
                throw new Exception("Список пуст");
            }
        }
        public List<RoomDto> Get()
        {
            return roomDtos;
        }
        public void Update(RoomDto roomDto)
        {
            roomDtos.Add(roomDto);
        }
        public void Delete(int id)
        {
            int n = roomDtos.Count;
            if (roomDtos != null)
            {
                foreach (RoomDto roomDto in roomDtos)
                {
                    if (roomDto.Id == id)
                    {
                        roomDtos.Remove(roomDto);
                        break;
                    }
                }
                if (n == roomDtos.Count)
                {
                    throw new Exception($"Элемент с id:{id} не найден");
                }
            }
            else
            {
                throw new Exception("Список пуст");
            }
        }
    }
}
