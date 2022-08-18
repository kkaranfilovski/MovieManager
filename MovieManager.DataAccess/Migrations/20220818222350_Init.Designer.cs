﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieManager.DataAccess.Data;

#nullable disable

namespace MovieManager.DataAccess.Migrations
{
    [DbContext(typeof(MovieManagerDbContext))]
    [Migration("20220818222350_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MovieManager.Domain.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7437),
                            Description = "Scientist Jor-El rockets his infant son, Kal-El, to safety on Earth. Kal is raised as Clark Kent and develops unusual abilities and powers to become Superman who fights for truth and justice.",
                            Genre = 6,
                            Title = "Superman",
                            Year = 1978
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7441),
                            Description = "Batman is called to intervene when the mayor of Gotham City is murdered. Soon, his investigation leads him to uncover a web of corruption, linked to his own dark past.",
                            Genre = 3,
                            Title = "The Batman",
                            Year = 2022
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7443),
                            Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                            Genre = 5,
                            Title = "The Godfather",
                            Year = 1972
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7446),
                            Description = "When a Chinese consul's young daughter is kidnapped, Hong Kong Detective Lee must team up with Carter, a loud-mouthed LA detective. Distinctive work styles and cultural differences pose hiccups.",
                            Genre = 1,
                            Title = "Rush Hour",
                            Year = 1998
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7447),
                            Description = "Duke reads the story of Allie and Noah, two lovers who were separated by fate, to Ms Hamilton, an old woman who suffers from dementia, on a daily basis out of his notebook.",
                            Genre = 7,
                            Title = "The Notebook",
                            Year = 2004
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7449),
                            Description = "The Perron family moves into a farmhouse where they experience paranormal phenomena. They consult demonologists, Ed and Lorraine Warren, to help them get rid of the evil entity haunting them.",
                            Genre = 2,
                            Title = "The Conjuring",
                            Year = 2013
                        },
                        new
                        {
                            Id = 7,
                            DateCreated = new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7451),
                            Description = "Nick Dunne discovers that the entire media focus has shifted on him when his wife, Amy Dunne, mysteriously disappears on the day of their fifth wedding anniversary.",
                            Genre = 4,
                            Title = "Gone Girl",
                            Year = 2014
                        });
                });

            modelBuilder.Entity("MovieManager.Domain.Models.MovieUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("MovieUser");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 3,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 4,
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            MovieId = 5,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("MovieManager.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FavoriteGenre")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7278),
                            FavoriteGenre = 6,
                            FirstName = "Kristijan",
                            LastName = "Karanfilovski",
                            Password = "kiko123",
                            Username = "kiko"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7311),
                            FavoriteGenre = 1,
                            FirstName = "Ilija",
                            LastName = "Mitev",
                            Password = "ile123",
                            Username = "ile"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2022, 8, 19, 0, 23, 49, 875, DateTimeKind.Local).AddTicks(7313),
                            FavoriteGenre = 3,
                            FirstName = "Trajan",
                            LastName = "Stevkovski",
                            Password = "trajan123",
                            Username = "trajan"
                        });
                });

            modelBuilder.Entity("MovieManager.Domain.Models.MovieUser", b =>
                {
                    b.HasOne("MovieManager.Domain.Models.Movie", "Movie")
                        .WithMany("UserList")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieManager.Domain.Models.User", "User")
                        .WithMany("MovieList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MovieManager.Domain.Models.Movie", b =>
                {
                    b.Navigation("UserList");
                });

            modelBuilder.Entity("MovieManager.Domain.Models.User", b =>
                {
                    b.Navigation("MovieList");
                });
#pragma warning restore 612, 618
        }
    }
}
