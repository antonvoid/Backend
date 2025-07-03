using HotelManager.Data.Component;
using HotelManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Data.Repositories.Room
{
    public interface IRoomRepository
    {
        Task<RoomEntity> GetById(int id);
        Task<List<RoomEntity>> Get();
        Task Update(RoomEntity roomEntity);
        Task Delete(int id);
        Task Create(RoomEntity roomEntity);
    }
}
