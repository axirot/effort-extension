﻿// <auto-generated />
using System;
using Effort.DB.Layer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Effort.DB.Layer.Migrations
{
    [DbContext(typeof(EffortDbContext))]
    [Migration("20200601134747_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("effort")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Effort.Models.ActivityType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Comment")
                        .HasMaxLength(250);

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("activity_type");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "analyze",
                            Color = "red",
                            Comment = "Анализ задачи",
                            Deleted = false,
                            Name = "Анализ"
                        },
                        new
                        {
                            Id = 2L,
                            Code = "develop",
                            Color = "green",
                            Comment = "Разработка",
                            Deleted = false,
                            Name = "Разработка"
                        },
                        new
                        {
                            Id = 3L,
                            Code = "test",
                            Color = "blue",
                            Comment = "Тестирование",
                            Deleted = false,
                            Name = "Тестирование"
                        });
                });

            modelBuilder.Entity("Effort.Models.Timesheet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ActivityTypeId");

                    b.Property<string>("Comment")
                        .HasMaxLength(250);

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Deleted");

                    b.Property<long>("Duration");

                    b.Property<DateTime>("Inserted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 6, 1, 16, 47, 47, 401, DateTimeKind.Local).AddTicks(5673));

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 6, 1, 16, 47, 47, 395, DateTimeKind.Local).AddTicks(982));

                    b.Property<string>("UserUniqueName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("WorkItemId");

                    b.HasKey("Id");

                    b.ToTable("timesheet");

                    b.HasData(
                        new
                        {
                            Id = -1L,
                            ActivityTypeId = 1L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(6171),
                            Deleted = true,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 11
                        },
                        new
                        {
                            Id = -2L,
                            ActivityTypeId = 1L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8286),
                            Deleted = false,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 22
                        },
                        new
                        {
                            Id = -3L,
                            ActivityTypeId = 1L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8325),
                            Deleted = false,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 33
                        },
                        new
                        {
                            Id = -4L,
                            ActivityTypeId = 2L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8328),
                            Deleted = true,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 44
                        },
                        new
                        {
                            Id = -5L,
                            ActivityTypeId = 2L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8338),
                            Deleted = false,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 55
                        },
                        new
                        {
                            Id = -6L,
                            ActivityTypeId = 2L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8339),
                            Deleted = false,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 66
                        },
                        new
                        {
                            Id = -7L,
                            ActivityTypeId = 2L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8341),
                            Deleted = false,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 77
                        },
                        new
                        {
                            Id = -8L,
                            ActivityTypeId = 3L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8343),
                            Deleted = true,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 88
                        },
                        new
                        {
                            Id = -9L,
                            ActivityTypeId = 3L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8344),
                            Deleted = false,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 99
                        },
                        new
                        {
                            Id = -10L,
                            ActivityTypeId = 3L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8346),
                            Deleted = false,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 100
                        },
                        new
                        {
                            Id = -11L,
                            ActivityTypeId = 3L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8348),
                            Deleted = false,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 110
                        },
                        new
                        {
                            Id = -12L,
                            ActivityTypeId = 3L,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 16, 47, 47, 403, DateTimeKind.Local).AddTicks(8349),
                            Deleted = false,
                            Duration = 15L,
                            UserUniqueName = "iloer",
                            WorkItemId = 120
                        });
                });
#pragma warning restore 612, 618
        }
    }
}