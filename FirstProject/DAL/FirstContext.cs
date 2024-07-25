using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FirstProject.DAL
{
    public class FirstContext : DbContext
    {
        public FirstContext(DbContextOptions<FirstContext> op): base (op) { }

        public DbSet<Hotel> Hotel { get; set; }

        public DbSet<HotelImages> HotelImages { get; set; }

        public DbSet<RoomImages> RoomImages { get; set; }

        public DbSet<Location> Location { get; set; }

        public DbSet<Reservation> Reservation { get; set; }

        public DbSet<Room> Room { get; set; }

        public DbSet<Room> Review { get; set; }

    }
}
