using FirstProject.DAL;
using FirstProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FirstProject.DsConn
{
    public class FirstContext : DbContext
    {
        public FirstContext(DbContextOptions<FirstContext> op) : base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Guest>().ToTable("Guest", "HotelManagementSystem");
            modelBuilder.Entity<Hotel>().ToTable("Hotel", "HotelManagementSystem");
            modelBuilder.Entity<HotelDetail>().ToTable("HotelDetail", "HotelManagementSystem");
            modelBuilder.Entity<Reservation>().ToTable("Reservation", "HotelManagementSystem");
            modelBuilder.Entity<Room>().ToTable("Room", "HotelManagementSystem");
            modelBuilder.Entity<RoomDetail>().ToTable("RoomDetail", "HotelManagementSystem");
            modelBuilder.Entity<Feedback>().ToTable("Feedback", "HotelManagementSystem");

        }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelDetail> HotelDetails { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomDetail> RoomDetails { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

    }
}
