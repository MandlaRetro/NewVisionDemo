﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewVisionAPIDemo.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NewVisionAPIDemo.Migrations
{
    [DbContext(typeof(ModelsContext))]
    [Migration("20190610085456_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("NewVisionAPIDemo.Models.Demo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Content");

                    b.Property<string>("ImageBase64");

                    b.HasKey("Id");

                    b.ToTable("Demos");
                });
#pragma warning restore 612, 618
        }
    }
}
