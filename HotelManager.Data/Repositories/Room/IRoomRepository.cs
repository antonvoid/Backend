using HotelManager.Data.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Data.Repositories.Room
{
    public interface IRoomRepository
    {
        RoomDto GetById(int id);
        List<RoomDto> Get();
        void Update(RoomDto roomDto);
        void Delete(int id);
        void Create(RoomDto roomDto);
    }
}
