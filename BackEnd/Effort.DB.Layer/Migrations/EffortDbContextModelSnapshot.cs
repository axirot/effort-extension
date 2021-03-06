﻿// <auto-generated />
using System;
using Effort.DB.Layer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Effort.DB.Layer.Migrations
{
    [DbContext(typeof(EffortDbContext))]
    partial class EffortDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("effort")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Effort.Models.ActivityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Comment")
                        .HasMaxLength(250);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("activity_type");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "analyze",
                            Color = "red",
                            Comment = "Анализ задачи",
                            IsDeleted = false,
                            Name = "Анализ"
                        },
                        new
                        {
                            Id = 2,
                            Code = "develop",
                            Color = "green",
                            Comment = "Разработка",
                            IsDeleted = false,
                            Name = "Разработка"
                        },
                        new
                        {
                            Id = 3,
                            Code = "test",
                            Color = "blue",
                            Comment = "Тестирование",
                            IsDeleted = false,
                            Name = "Тестирование"
                        });
                });

            modelBuilder.Entity("Effort.Models.Timesheet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityTypeId");

                    b.Property<string>("Comment")
                        .HasMaxLength(250);

                    b.Property<DateTime>("Date");

                    b.Property<int>("Duration");

                    b.Property<DateTime>("Inserted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 6, 1, 23, 16, 40, 570, DateTimeKind.Local).AddTicks(1077));

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 6, 1, 23, 16, 40, 561, DateTimeKind.Local).AddTicks(4248));

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
                            ActivityTypeId = 1,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(3280),
                            Duration = 15,
                            IsDeleted = true,
                            UserUniqueName = "iloer",
                            WorkItemId = 11
                        },
                        new
                        {
                            Id = -2L,
                            ActivityTypeId = 1,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5157),
                            Duration = 15,
                            IsDeleted = false,
                            UserUniqueName = "iloer",
                            WorkItemId = 22
                        },
                        new
                        {
                            Id = -3L,
                            ActivityTypeId = 1,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5172),
                            Duration = 15,
                            IsDeleted = false,
                            UserUniqueName = "iloer",
                            WorkItemId = 33
                        },
                        new
                        {
                            Id = -4L,
                            ActivityTypeId = 2,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5174),
                            Duration = 15,
                            IsDeleted = true,
                            UserUniqueName = "iloer",
                            WorkItemId = 44
                        },
                        new
                        {
                            Id = -5L,
                            ActivityTypeId = 2,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5178),
                            Duration = 15,
                            IsDeleted = false,
                            UserUniqueName = "iloer",
                            WorkItemId = 55
                        },
                        new
                        {
                            Id = -6L,
                            ActivityTypeId = 2,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5179),
                            Duration = 15,
                            IsDeleted = false,
                            UserUniqueName = "iloer",
                            WorkItemId = 66
                        },
                        new
                        {
                            Id = -7L,
                            ActivityTypeId = 2,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5180),
                            Duration = 15,
                            IsDeleted = false,
                            UserUniqueName = "iloer",
                            WorkItemId = 77
                        },
                        new
                        {
                            Id = -8L,
                            ActivityTypeId = 3,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5181),
                            Duration = 15,
                            IsDeleted = true,
                            UserUniqueName = "iloer",
                            WorkItemId = 88
                        },
                        new
                        {
                            Id = -9L,
                            ActivityTypeId = 3,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5182),
                            Duration = 15,
                            IsDeleted = false,
                            UserUniqueName = "iloer",
                            WorkItemId = 99
                        },
                        new
                        {
                            Id = -10L,
                            ActivityTypeId = 3,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5183),
                            Duration = 15,
                            IsDeleted = false,
                            UserUniqueName = "iloer",
                            WorkItemId = 100
                        },
                        new
                        {
                            Id = -11L,
                            ActivityTypeId = 3,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5184),
                            Duration = 15,
                            IsDeleted = false,
                            UserUniqueName = "iloer",
                            WorkItemId = 110
                        },
                        new
                        {
                            Id = -12L,
                            ActivityTypeId = 3,
                            Comment = "текст",
                            Date = new DateTime(2020, 6, 1, 23, 16, 40, 572, DateTimeKind.Local).AddTicks(5185),
                            Duration = 15,
                            IsDeleted = false,
                            UserUniqueName = "iloer",
                            WorkItemId = 120
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
