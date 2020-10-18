﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UdemyNLayerProject.Data;

namespace UdemyNLayerProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201018150202_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("UdemyNLayerProject.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kalemler",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            Name = "Defterler",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("UdemyNLayerProject.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("InnerBarcode")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal (18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("integer");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Pilot Kalem",
                            Price = 12.50m,
                            Stock = 100,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Kurşun Kalem",
                            Price = 40.50m,
                            Stock = 200,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "Tükenmez Kalem",
                            Price = 500m,
                            Stock = 300,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Name = "Küçük Boy Defter",
                            Price = 12.50m,
                            Stock = 100,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Name = "Orta Boy Defter",
                            Price = 12.50m,
                            Stock = 100,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Name = "Büyük Boy Defter",
                            Price = 12.50m,
                            Stock = 100,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("UdemyNLayerProject.Core.Models.Product", b =>
                {
                    b.HasOne("UdemyNLayerProject.Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
