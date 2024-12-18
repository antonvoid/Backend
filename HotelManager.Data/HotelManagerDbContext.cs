using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.Data.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace HotelManager.Data
{
    public class HotelManagerDbContext : DbContext 
    {
        public DbSet<RoomEntity> Rooms { get; set; } = null!;
        public HotelManagerDbContext()
        {
        }
        public HotelManagerDbContext(DbContextOptions<HotelManagerDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .Build().GetConnectionString("Default");
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
