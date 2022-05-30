﻿// <auto-generated />
using BarinakTakip.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BarinakTakip.Migrations
{
    [DbContext(typeof(ApplicationConnectionDb))]
    [Migration("20220530143953_Initial-V1")]
    partial class InitialV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BarinakTakip.Models.Barinak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Adres")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Mail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Soyad")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefon")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Barinak");
                });
#pragma warning restore 612, 618
        }
    }
}
