﻿// <auto-generated />
using System;
using EntityProject.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityProject.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20230718125050_film")]
    partial class film
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityProject.Entities.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("actor_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("first_name");

                    b.Property<string>("SegundoNome")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("actor", (string)null);
                });

            modelBuilder.Entity("EntityProject.Entities.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("film_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AnoLancamento")
                        .IsRequired()
                        .HasColumnType("varchar(4)")
                        .HasColumnName("release_year");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Nota")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("rating");

                    b.Property<short>("Tamanho")
                        .HasColumnType("smallint")
                        .HasColumnName("length");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("title");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("film", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
