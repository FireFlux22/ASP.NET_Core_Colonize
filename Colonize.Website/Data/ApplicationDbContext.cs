using Colonize.Website.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Colonize.Website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Voyage> Voyage { get; set; }
        public DbSet<Ship> Ship { get; set; }
        public DbSet<Destination> Destination { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VoyageIdentityUser>()
               .HasKey(bc => new { bc.VoyageId, bc.IdentityUserId });

            SeedDatabase(modelBuilder);

            SeedProducts(modelBuilder);

        }

        private void SeedProducts(ModelBuilder modelBuilder)
        {
            var products = new List<Product>
            {
                new Product(1,
                    "Facehugger Plushie",
                    "Lovely facehugger great quality family friendly buy now",
                    29,
                    "COL-123-2568",
                     new Uri ("https://img.fruugo.com/product/4/36/95205364_max.jpg"),
                    "facehugger-plushie"),
                new Product(2, 
                    "Moonshot model ship",
                    "Not the acutal size of the spaceship",
                    19,
                    "COL-345-1234",
                    new Uri ("https://i.pinimg.com/originals/bf/f9/2b/bff92b658e36100d1b57b94c18b5dd5f.jpg"),
                    "moonshot-model")
            };

            products.ForEach(x => modelBuilder.Entity<Product>().HasData(x));

        }

        private static void SeedDatabase(ModelBuilder modelBuilder)
        {
            List<Ship> ships = SeedShips(modelBuilder);
            List<Destination> destinations = SeedDestinations(modelBuilder);

            SeedVoyages(modelBuilder, ships, destinations);

            SeedUsers(modelBuilder);
        }

        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var johnDoe = new IdentityUser()
            {
                Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                UserName = "john.doe@nomail.com",
                Email = "john.doe@nomail.com",
                NormalizedEmail = "john.doe@nomail.com",
                EmailConfirmed = true,
                PhoneNumber = "0707-12345",
                PasswordHash = hasher.HashPassword(null, "Secret#123"),
                SecurityStamp = string.Empty
            };

            modelBuilder.Entity<IdentityUser>().HasData(johnDoe);
        }

        private static void SeedVoyages(ModelBuilder modelBuilder, List<Ship> ships, List<Destination> destinations)
        {
            var moonshot = ships.Find(x => x.Name == "Moonshot");
            var marsExplorer = ships.Find(x => x.Name == "Mars Explorer");

            var moon = destinations.Find(x => x.Name == "Moon");
            var mars = destinations.Find(x => x.Name == "Mars");

            var voyages = new List<Voyage>
            {
                new Voyage(1, moon.Id, moonshot.Id, new DateTime(2024, 6, 4), new DateTime(2024, 6, 8)),
                new Voyage(2, mars.Id, marsExplorer.Id, new DateTime(2028, 12, 1), new DateTime(2029, 2, 1)),
            };

            voyages.ForEach(x => modelBuilder.Entity<Voyage>().HasData(x));
        }

        private static List<Destination> SeedDestinations(ModelBuilder modelBuilder)
        {
            var destinations = new List<Destination>
            {
                new Destination(1, "Moon", "Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/1280x280.png?text=Moon", UriKind.Absolute)),
                new Destination(2, "Mars", "Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/1280x280.png?text=Mars", UriKind.Absolute)),
            };

            destinations.ForEach(x => modelBuilder.Entity<Destination>().HasData(x));

            return destinations;
        }

        private static List<Ship> SeedShips(ModelBuilder modelBuilder)
        {
            var ships = new List<Ship>
            {
                new Ship(1, "Moonshot", "Lorem ipsum dolor", 200,
                    new Uri("https://via.placeholder.com/480x360.png?text=Moonshot", UriKind.Absolute)),
                new Ship(2, "Mars Explorer", "Lorem ipsum dolor", 2800,
                    new Uri("https://via.placeholder.com/480x360.png?text=Mars+Explorer", UriKind.Absolute)),
            };

            ships.ForEach(x => modelBuilder.Entity<Ship>().HasData(x));

            return ships;
        }

        public DbSet<Colonize.Website.Data.Entities.Product> Product { get; set; }
    }
}
