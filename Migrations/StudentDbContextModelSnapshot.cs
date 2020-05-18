﻿// <auto-generated />
using System;
using APBD09.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APBD09.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation(
                "ProductVersion",
                "3.1.4")
                .HasAnnotation(
                "Relational:MaxIdentifierLength",
                128)
                .HasAnnotation(
                "SqlServer:ValueGenerationStrategy",
                SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APBD09.Models.Student", b =>
                {
                    b.Property<string>("IndexNumber").HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate").HasColumnType("datetime2");

                    b.Property<string>("FirstName").HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEnrollment").HasColumnType("int");

                    b.Property<string>("LastName").HasColumnType("nvarchar(max)");

                    b.HasKey("IndexNumber");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
