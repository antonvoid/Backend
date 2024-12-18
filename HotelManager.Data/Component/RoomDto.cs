using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Data.Component
{
    public class RoomDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public Type Type { get; set; }
        public decimal Price { get; set; }
        public RoomDto(int id, int number, Type type, decimal price) 
        {
            Id = id;
            Number = number;
            Type = type;
            Price = price;
        }
    }
    public enum Type
    {
        economy,
        standart,
        luxury
    }
}
