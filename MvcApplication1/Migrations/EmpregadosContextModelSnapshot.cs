﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcApplication1.Models;

#nullable disable

namespace MvcApplication1.Migrations
{
    [DbContext(typeof(EmpregadosContext))]
    partial class EmpregadosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MvcApplication1.Models.Empregados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cargo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Endereco")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Empregados");
                });
#pragma warning restore 612, 618
        }
    }
}
