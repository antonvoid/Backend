using HotelManager.Data.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Domain.Services.Room
{
    public interface IRoomService
    {
        Task<RoomDto> GetById(int id);
        Task<List<RoomDto>> Get();
        Task Update(RoomDto roomDto);
        Task Delete(int id);
        Task Create(RoomDto roomDto);
    }
}
