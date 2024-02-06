﻿// <auto-generated />
using System;
using EmployeeMgmt.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EmployeeMgmt.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EmployeeMgmt.Models.Company", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("company_id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("company_name");

                    b.HasKey("CompanyId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("companies");

                    b.HasData(
                        new
                        {
                            CompanyId = new Guid("f1bd225f-a114-473b-b9ae-13de83feac57"),
                            Address = "Addis Ababa, Ethiopia",
                            Name = "Hi Tech"
                        },
                        new
                        {
                            CompanyId = new Guid("c56d2e35-cbbc-4c11-9382-c19a77d0f025"),
                            Address = "Nairobi, Kenya",
                            Name = "Lead Tech"
                        },
                        new
                        {
                            CompanyId = new Guid("67e91a90-56e4-4339-9fbe-c370d16db1d5"),
                            Address = "Legos, Naigeria",
                            Name = "Info Model"
                        });
                });

            modelBuilder.Entity("EmployeeMgmt.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("employee_id");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<string>("FristName")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasColumnName("position");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7d40cfc8-f801-4f84-80e1-a8605cbda9f5"),
                            CompanyId = new Guid("f1bd225f-a114-473b-b9ae-13de83feac57"),
                            FristName = "Doe",
                            LastName = "John",
                            PhoneNumber = "2519-2334-23-34",
                            Position = "Software Enginner I"
                        },
                        new
                        {
                            Id = new Guid("bfa08ba6-58ae-4ebc-b739-c61c585dd2ec"),
                            CompanyId = new Guid("c56d2e35-cbbc-4c11-9382-c19a77d0f025"),
                            FristName = "Smith",
                            LastName = "Kyle",
                            PhoneNumber = "2519-4334-23-44",
                            Position = "Software Enginner II"
                        },
                        new
                        {
                            Id = new Guid("d8aa10d8-32b1-46eb-8446-0caa6634c6fa"),
                            CompanyId = new Guid("67e91a90-56e4-4339-9fbe-c370d16db1d5"),
                            FristName = "Helen",
                            LastName = "Million",
                            PhoneNumber = "+1029-2334-23-34",
                            Position = "Software Enginner III"
                        });
                });

            modelBuilder.Entity("EmployeeMgmt.Models.Employee", b =>
                {
                    b.HasOne("EmployeeMgmt.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EmployeeMgmt.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}