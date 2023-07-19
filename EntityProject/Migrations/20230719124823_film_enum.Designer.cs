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
    [Migration("20230719124823_film_enum")]
    partial class film_enum
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

                    b.HasAlternateKey("PrimeiroNome", "SegundoNome");

                    b.HasIndex("SegundoNome")
                        .HasDatabaseName("idx_actor_last_name");

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

                    b.Property<short>("Duracao")
                        .HasColumnType("smallint")
                        .HasColumnName("length");

                    b.Property<string>("TextoClassificacao")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("rating");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("title");

                    b.Property<byte>("language_id")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<byte?>("original_language_id")
                        .IsRequired()
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("language_id");

                    b.HasIndex("original_language_id");

                    b.ToTable("film", (string)null);
                });

            modelBuilder.Entity("EntityProject.Entities.FilmeAtor", b =>
                {
                    b.Property<int>("actor_id")
                        .HasColumnType("int");

                    b.Property<int>("film_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("actor_id", "film_id");

                    b.HasIndex("film_id");

                    b.ToTable("film_actor", (string)null);
                });

            modelBuilder.Entity("EntityProject.Entities.Idioma", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint")
                        .HasColumnName("language_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("char(20)")
                        .HasColumnName("name");

                    b.Property<DateTime>("last_update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.ToTable("language", (string)null);
                });

            modelBuilder.Entity("EntityProject.Entities.Filme", b =>
                {
                    b.HasOne("EntityProject.Entities.Idioma", "IdiomaFalado")
                        .WithMany("FilmeFalados")
                        .HasForeignKey("language_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityProject.Entities.Idioma", "IdiomaOriginal")
                        .WithMany("FilmeOriginais")
                        .HasForeignKey("original_language_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdiomaFalado");

                    b.Navigation("IdiomaOriginal");
                });

            modelBuilder.Entity("EntityProject.Entities.FilmeAtor", b =>
                {
                    b.HasOne("EntityProject.Entities.Ator", "Ator")
                        .WithMany("FilmeAtores")
                        .HasForeignKey("actor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityProject.Entities.Filme", "Filme")
                        .WithMany("FilmeAtores")
                        .HasForeignKey("film_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ator");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("EntityProject.Entities.Ator", b =>
                {
                    b.Navigation("FilmeAtores");
                });

            modelBuilder.Entity("EntityProject.Entities.Filme", b =>
                {
                    b.Navigation("FilmeAtores");
                });

            modelBuilder.Entity("EntityProject.Entities.Idioma", b =>
                {
                    b.Navigation("FilmeFalados");

                    b.Navigation("FilmeOriginais");
                });
#pragma warning restore 612, 618
        }
    }
}
