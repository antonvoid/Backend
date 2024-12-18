using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.Data.Component;
using HotelManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelManager.Data.Repositories.Room
{
    public class RoomRepository : IRoomRepository
    {
        private HotelManagerDbContext dbContext = new HotelManagerDbContext();

        public async Task<RoomEntity> GetById(int id)
        {
            return await dbContext.Rooms.FirstOrDefaultAsync(r => r.Id == id);
        }
        public async Task<List<RoomEntity>> Get()
        {
            return await dbContext.Rooms.ToListAsync();
        }
        public async Task Update(RoomEntity roomEntity)
        {
            await dbContext.Rooms.
                Where(r => r.Id == roomEntity.Id)
                .ExecuteUpdateAsync(r => r.SetProperty(r => r.Number, roomEntity.Number)
                .SetProperty(r => r.Type, roomEntity.Type)
                .SetProperty(r => r.Price, roomEntity.Price));
        }
        public async Task Delete(int id)
        {

            await dbContext.Rooms.Where(r => r.Id == id).ExecuteDeleteAsync();
        }
        public async Task Create(RoomEntity roomEntity)
        {
            await dbContext.Rooms.AddAsync(roomEntity);
            await dbContext.SaveChangesAsync();
        }
    }
}
