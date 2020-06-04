﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vidly;

namespace Vidly.Migrations
{
    [DbContext(typeof(VidlyDbContext))]
    partial class VidlyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSubscribedToNewsletter")
                        .HasColumnType("bit");

                    b.Property<int>("MembershipTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MembershipTypeId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1996, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsSubscribedToNewsletter = true,
                            MembershipTypeId = 1,
                            Name = "Jaspal"
                        },
                        new
                        {
                            Id = 2,
                            IsSubscribedToNewsletter = false,
                            MembershipTypeId = 4,
                            Name = "Harpreet"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsSubscribedToNewsletter = true,
                            MembershipTypeId = 3,
                            Name = "Vikram"
                        },
                        new
                        {
                            Id = 4,
                            IsSubscribedToNewsletter = false,
                            MembershipTypeId = 2,
                            Name = "Harkawal"
                        });
                });

            modelBuilder.Entity("Vidly.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("Vidly.Models.MembershipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("DiscountRate")
                        .HasColumnType("tinyint");

                    b.Property<byte>("DurationInMonths")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("SignUpFee")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MembershipType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscountRate = (byte)0,
                            DurationInMonths = (byte)0,
                            Name = "Pay As You Go",
                            SignUpFee = (short)0
                        },
                        new
                        {
                            Id = 2,
                            DiscountRate = (byte)10,
                            DurationInMonths = (byte)1,
                            Name = "Monthly",
                            SignUpFee = (short)30
                        },
                        new
                        {
                            Id = 3,
                            DiscountRate = (byte)15,
                            DurationInMonths = (byte)3,
                            Name = "Quarterly",
                            SignUpFee = (short)90
                        },
                        new
                        {
                            Id = 4,
                            DiscountRate = (byte)30,
                            DurationInMonths = (byte)12,
                            Name = "Yearly",
                            SignUpFee = (short)300
                        });
                });

            modelBuilder.Entity("Vidly.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NumberInStock")
                        .HasColumnType("decimal(20,0)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 5,
                            Name = "The Seven Samurai",
                            NumberInStock = 10m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 2,
                            Name = "Bonnie and Clyde",
                            NumberInStock = 100m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 3,
                            Name = "Reservoir Dogs",
                            NumberInStock = 30m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            Name = "Airplane!",
                            NumberInStock = 50m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 3,
                            Name = "Pan's Labyrinth",
                            NumberInStock = 5m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            Name = "Doctor Zhivago",
                            NumberInStock = 10m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            Name = "Pulp Fiction",
                            NumberInStock = 4m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 4,
                            Name = "The Shawshank Redemption",
                            NumberInStock = 6m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            Name = "Citizen Kane",
                            NumberInStock = 8m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 4,
                            Name = "The Wizard of Oz",
                            NumberInStock = 0m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            DateAdded = new DateTime(1990, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 4,
                            Name = "The Godfather",
                            NumberInStock = 90m,
                            ReleaseDate = new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.HasOne("Vidly.Models.MembershipType", "MembershipType")
                        .WithMany()
                        .HasForeignKey("MembershipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vidly.Models.Movie", b =>
                {
                    b.HasOne("Vidly.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");
                });
#pragma warning restore 612, 618
        }
    }
}
