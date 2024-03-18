﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhanTichCamXucVanBan.Data;

#nullable disable

namespace PhanTichCamXucVanBan.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240318034742_Initialized")]
    partial class Initialized
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PhanTichCamXucVanBan.Models.CamXuc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("HaiLong")
                        .HasColumnType("bit");

                    b.Property<bool>("KhaHaiLong")
                        .HasColumnType("bit");

                    b.Property<string>("KhongGian")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KhongHaiLong")
                        .HasColumnType("bit");

                    b.Property<bool>("RatHaiLong")
                        .HasColumnType("bit");

                    b.Property<bool>("RatKhongHaiLong")
                        .HasColumnType("bit");

                    b.Property<string>("ThaiDo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ThatVong")
                        .HasColumnType("bit");

                    b.Property<string>("ThucAn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("camXucs");
                });
#pragma warning restore 612, 618
        }
    }
}
