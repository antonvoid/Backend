using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.Data.Component;
using HotelManager.Data.Entities;
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
        public async Task<RoomDto> GetById(int id)
        {
            RoomEntity roomEntity = await _repository.GetById(id);
            RoomDto roomDto = new RoomDto(roomEntity.Id, roomEntity.Number, (HotelManager.Data.Component.Type)roomEntity.Type, roomEntity.Price);
            return roomDto;
        }
        public async Task<List<RoomDto>> Get()
        {
            List<RoomEntity> roomEntites = await _repository.Get();
            List<RoomDto> roomDtos = new List<RoomDto>();
            foreach (RoomEntity roomEntity in roomEntites)
            {
                RoomDto roomDto = new RoomDto(roomEntity.Id, roomEntity.Number, (HotelManager.Data.Component.Type)roomEntity.Type, roomEntity.Price);
                roomDtos.Add(roomDto);
            }
            return roomDtos;
        }
        public async Task Update(RoomDto roomDto)
        {
            RoomEntity roomEntity = new RoomEntity(roomDto.Id, roomDto.Number, (HotelManager.Data.Entities.Type)roomDto.Type, roomDto.Price);
            await _repository.Update(roomEntity);
        }
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
        public async Task Create(RoomDto roomDto)
        {
            RoomEntity roomEntity = new RoomEntity(roomDto.Id, roomDto.Number, (HotelManager.Data.Entities.Type)roomDto.Type, roomDto.Price);
            await _repository.Create(roomEntity);
        }
    }
}
