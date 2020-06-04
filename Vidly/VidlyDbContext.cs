using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vidly.Models;

namespace Vidly
{
    public class VidlyDbContext : DbContext
    {
        public VidlyDbContext(DbContextOptions<VidlyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType{Id = 1, SignUpFee = 0, DiscountRate = 0, DurationInMonths = 0, Name = "Pay As You Go"},
                new MembershipType { Id = 2, SignUpFee = 30, DiscountRate = 10, DurationInMonths = 1, Name = "Monthly"},
                new MembershipType { Id = 3, SignUpFee = 90, DiscountRate = 15, DurationInMonths = 3, Name = "Quarterly"},
                new MembershipType { Id = 4, SignUpFee = 300, DiscountRate = 30, DurationInMonths = 12, Name = "Yearly"}
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Jaspal", IsSubscribedToNewsletter = true, MembershipTypeId = 1, BirthDate = new DateTime(1996,02, 2)},
                new Customer { Id = 2, Name = "Harpreet", IsSubscribedToNewsletter = false, MembershipTypeId = 4},
                new Customer { Id = 3, Name = "Vikram", IsSubscribedToNewsletter = true, MembershipTypeId = 3, BirthDate = new DateTime(1990, 02, 2) },
                new Customer { Id = 4, Name = "Harkawal", IsSubscribedToNewsletter = false, MembershipTypeId = 2 }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie {Id = 1, Name = "The Seven Samurai" },
                new Movie {Id = 2, Name = "Bonnie and Clyde" },
                new Movie {Id = 3, Name = "Reservoir Dogs" },
                new Movie {Id = 4, Name = "Airplane!" },
                new Movie {Id = 5, Name = "Pan's Labyrinth" },
                new Movie {Id = 6, Name = "Doctor Zhivago" },
                new Movie {Id = 7, Name = "Pulp Fiction" },
                new Movie {Id = 8, Name = "The Shawshank Redemption" },
                new Movie {Id = 9, Name = "Citizen Kane" },
                new Movie {Id = 10, Name = "The Wizard of Oz" },
                new Movie {Id = 11, Name = "The Godfather" }
                );
        }
    }
}
