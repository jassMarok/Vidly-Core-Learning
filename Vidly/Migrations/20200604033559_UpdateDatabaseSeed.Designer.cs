﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vidly;

namespace Vidly.Migrations
{
    [DbContext(typeof(VidlyDbContext))]
    [Migration("20200604033559_UpdateDatabaseSeed")]
    partial class UpdateDatabaseSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "The Seven Samurai"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bonnie and Clyde"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Reservoir Dogs"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Airplane!"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pan's Labyrinth"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Doctor Zhivago"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 8,
                            Name = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Citizen Kane"
                        },
                        new
                        {
                            Id = 10,
                            Name = "The Wizard of Oz"
                        },
                        new
                        {
                            Id = 11,
                            Name = "The Godfather"
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
#pragma warning restore 612, 618
        }
    }
}
