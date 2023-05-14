﻿// <auto-generated />
using EFTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230514140437_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EFTest.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("pracownicy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Adamcka 12",
                            Email = "oczyzielone@zenek.pl",
                            Name = "Zenon Martyniuk"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Adamcka 14",
                            Email = "mene@zenek.pl",
                            Name = "Adam Nowak"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
