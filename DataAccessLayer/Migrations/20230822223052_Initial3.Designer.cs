﻿// <auto-generated />
using System;
using EmployeeManagment.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230822223052_Initial3")]
    partial class Initial3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagment.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IT Department"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Marketing Department"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Finance Department"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sales Department"
                        });
                });

            modelBuilder.Entity("EmployeeManagment.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentID = 1,
                            Email = "john@example.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Doe",
                            PhotoPath = "/images/john.jpg"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1985, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentID = 2,
                            Email = "jane@example.com",
                            FirstName = "Jane",
                            Gender = 1,
                            LastName = "Smith",
                            PhotoPath = "/images/2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1982, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentID = 3,
                            Email = "michael@example.com",
                            FirstName = "Michael",
                            Gender = 0,
                            LastName = "Johnson",
                            PhotoPath = "/images/3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1995, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentID = 4,
                            Email = "Emily@example.com",
                            FirstName = "Emily",
                            Gender = 1,
                            LastName = "Williams",
                            PhotoPath = "/images/4.jpg"
                        });
                });

            modelBuilder.Entity("EmployeeManagment.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagment.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EmployeeManagment.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
