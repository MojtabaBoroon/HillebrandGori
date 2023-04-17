﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShipmentApp.Persistence.DataAccessContext;

#nullable disable

namespace ShipmentApp.Migrations
{
    [DbContext(typeof(HillebrandGoriDbContext))]
    [Migration("20230414183258_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShipmentApp.DomainModels.Dates.ShipmentDate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReadyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ShipmentDate");
                });
#pragma warning restore 612, 618
        }
    }
}
