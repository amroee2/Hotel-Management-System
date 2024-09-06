﻿// <auto-generated />
using System;
using FirstProject.DsConn;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstProject.Migrations
{
    [DbContext(typeof(FirstContext))]
    partial class FirstContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FirstProject.DAL.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuestId"));

                    b.Property<string>("GuestEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuestId");

                    b.ToTable("Guest", "HotelManagementSystem");
                });

            modelBuilder.Entity("FirstProject.DAL.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"));

                    b.Property<string>("HotelDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelId");

                    b.ToTable("Hotel", "HotelManagementSystem");
                });

            modelBuilder.Entity("FirstProject.DAL.HotelDetail", b =>
                {
                    b.Property<int>("HotelDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelDetailID"));

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<string>("HotelImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelDetailID");

                    b.HasIndex("HotelID");

                    b.ToTable("HotelDetail", "HotelManagementSystem");
                });

            modelBuilder.Entity("FirstProject.DAL.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<DateTimeOffset?>("EndDate")
                        .IsRequired()
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("GuestID")
                        .HasColumnType("int");

                    b.Property<bool>("ReservationStatus")
                        .HasColumnType("bit");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("StartDate")
                        .IsRequired()
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("TotalAmount")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("GuestID");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservation", "HotelManagementSystem");
                });

            modelBuilder.Entity("FirstProject.DAL.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"));

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("RoomImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.HasIndex("HotelID");

                    b.ToTable("Room", "HotelManagementSystem");
                });

            modelBuilder.Entity("FirstProject.DAL.RoomDetail", b =>
                {
                    b.Property<int>("RoomDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomDetailId"));

                    b.Property<int>("RoomCapacity")
                        .HasColumnType("int");

                    b.Property<int>("RoomDetailCount")
                        .HasColumnType("int");

                    b.Property<string>("RoomDetailName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("RoomDetailId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomDetail", "HotelManagementSystem");
                });

            modelBuilder.Entity("FirstProject.Models.Feedback", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewID"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(Max)");

                    b.Property<int>("GuestID")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("ReviewDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("ReviewID");

                    b.HasIndex("GuestID");

                    b.ToTable("Feedback", "HotelManagementSystem");
                });

            modelBuilder.Entity("FirstProject.DAL.HotelDetail", b =>
                {
                    b.HasOne("FirstProject.DAL.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("FirstProject.DAL.Reservation", b =>
                {
                    b.HasOne("FirstProject.DAL.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirstProject.DAL.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("FirstProject.DAL.Room", b =>
                {
                    b.HasOne("FirstProject.DAL.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("FirstProject.DAL.RoomDetail", b =>
                {
                    b.HasOne("FirstProject.DAL.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("FirstProject.Models.Feedback", b =>
                {
                    b.HasOne("FirstProject.DAL.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");
                });
#pragma warning restore 612, 618
        }
    }
}
