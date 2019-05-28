﻿// <auto-generated />
using AulaCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AulaCore.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20190514234659_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AulaCore.Models.Cidade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.Property<int>("qtdeCli");

                    b.Property<string>("uf")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("id");

                    b.ToTable("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}
