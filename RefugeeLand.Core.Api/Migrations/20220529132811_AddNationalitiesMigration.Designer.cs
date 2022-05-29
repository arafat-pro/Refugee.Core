﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RefugeeLand.Core.Api.Brokers.Storages;

#nullable disable

namespace RefugeeLand.Core.Api.Migrations
{
    [DbContext(typeof(StorageBroker))]
    [Migration("20220529132811_AddNationalitiesMigration")]
    partial class AddNationalitiesMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Languages.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FluencyLevel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RefugeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RefugeeId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Nationalities.Nationality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RefugeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RefugeeId");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Refugees.Refugee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CurrentLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsOpenToWork")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalConditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillSets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Refugees");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Languages.Language", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.Refugees.Refugee", null)
                        .WithMany("Languages")
                        .HasForeignKey("RefugeeId");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Nationalities.Nationality", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.Refugees.Refugee", null)
                        .WithMany("Nationalities")
                        .HasForeignKey("RefugeeId");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Refugees.Refugee", b =>
                {
                    b.Navigation("Languages");

                    b.Navigation("Nationalities");
                });
#pragma warning restore 612, 618
        }
    }
}
