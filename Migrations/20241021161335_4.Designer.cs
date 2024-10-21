﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AmableQuishpePromBurgers.Migrations
{
    [DbContext(typeof(PromBurgersContext))]
    [Migration("20241021161335_4")]
    partial class _4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AmableQuishpePromBurgers.Models.Burges", b =>
                {
                    b.Property<int>("BurgesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BurgesId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("WithCheese")
                        .HasColumnType("bit");

                    b.HasKey("BurgesId");

                    b.ToTable("Burges");
                });

            modelBuilder.Entity("AmableQuishpePromBurgers.Models.Promo", b =>
                {
                    b.Property<int>("PromoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PromoId"));

                    b.Property<int>("BurgesId")
                        .HasColumnType("int");

                    b.Property<string>("Descrpcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaPromo")
                        .HasColumnType("datetime2");

                    b.HasKey("PromoId");

                    b.HasIndex("BurgesId");

                    b.ToTable("Promo");
                });

            modelBuilder.Entity("AmableQuishpePromBurgers.Models.Promo", b =>
                {
                    b.HasOne("AmableQuishpePromBurgers.Models.Burges", "Burges")
                        .WithMany("Promos")
                        .HasForeignKey("BurgesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burges");
                });

            modelBuilder.Entity("AmableQuishpePromBurgers.Models.Burges", b =>
                {
                    b.Navigation("Promos");
                });
#pragma warning restore 612, 618
        }
    }
}
