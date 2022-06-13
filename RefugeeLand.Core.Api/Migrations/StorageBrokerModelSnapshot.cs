﻿// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO DELIVER HUMANITARIAN AID, HOPE AND LOVE
// -------------------------------------------------------

// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RefugeeLand.Core.Api.Brokers.Storages;

#nullable disable

namespace RefugeeLand.Core.Api.Migrations
{
    [DbContext(typeof(StorageBroker))]
    partial class StorageBrokerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.MedicalConditions.MedicalCondition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicalConditions");
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

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.PetMedicalConditions.PetMedicalCondition", b =>
                {
                    b.Property<Guid>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MedicalConditionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PetId", "MedicalConditionId");

                    b.HasIndex("MedicalConditionId");

                    b.ToTable("PetMedicalConditions");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Pets.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeeGroups.RefugeeGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("RefugeeGroups");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeePets.RefugeePet", b =>
                {
                    b.Property<Guid>("RefugeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RefugeeId", "PetId");

                    b.HasIndex("PetId");

                    b.ToTable("RefugeePets");
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

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CurrentLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsOpenToWork")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RefugeeGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("RefugeeGroupId");

                    b.ToTable("Refugees");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.PetMedicalConditions.PetMedicalCondition", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.MedicalConditions.MedicalCondition", "MedicalCondition")
                        .WithMany("PetMedicalConditions")
                        .HasForeignKey("MedicalConditionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RefugeeLand.Core.Api.Models.Pets.Pet", "Pet")
                        .WithMany("PetMedicalConditions")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("MedicalCondition");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeePets.RefugeePet", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.Pets.Pet", "Pet")
                        .WithMany("RefugeePets")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RefugeeLand.Core.Api.Models.Refugees.Refugee", "Refugee")
                        .WithMany("RefugeePets")
                        .HasForeignKey("RefugeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("Refugee");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Refugees.Refugee", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.RefugeeGroups.RefugeeGroup", null)
                        .WithMany("Refugee")
                        .HasForeignKey("RefugeeGroupId");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.MedicalConditions.MedicalCondition", b =>
                {
                    b.Navigation("PetMedicalConditions");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Pets.Pet", b =>
                {
                    b.Navigation("PetMedicalConditions");

                    b.Navigation("RefugeePets");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeeGroups.RefugeeGroup", b =>
                {
                    b.Navigation("Refugee");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Refugees.Refugee", b =>
                {
                    b.Navigation("RefugeePets");
                });
#pragma warning restore 612, 618
        }
    }
}
