using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.Data.Component;

namespace HotelManager.Data.Repositories.Room
{
    public class RoomRepository : IRoomRepository
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
            return roomDtos.FirstOrDefault(r => r.Id == id);
        }
        public List<RoomDto> Get()
        {
            return roomDtos;
        }
        public void Update(RoomDto roomDto)
        {
            for (int i = 0; i < roomDtos.Count; i++)
            {
                if (roomDto.Id == roomDtos[i].Id)
                {
                    roomDtos[i] = roomDto;
                    break;
                }               
            }
        }
        public void Delete(int id)
        {
            roomDtos.RemoveAll(r => r.Id == id);
        }
        public void Create(RoomDto roomDto)
        {
            roomDtos.Add(roomDto);
        }
    }
}
