using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Jazzima1.Models;
using Microsoft.AspNetCore.Identity;

namespace Jazzima1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Album> Album { get; set; }
        public DbSet<Musician> Musician { get; set; }
        public DbSet<MusicianAlbum> MusicianAlbum { get; set; }
        public DbSet<SavedAlbums> SavedAlbums { get; set; }
        public DbSet<Comments> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Album maidenVoyage = new Album()
            {
                Id = 1,
                Title = "Maiden Voyage",
                ReleaseDate = 1965,
                Image = "https://en.wikipedia.org/wiki/File:Maiden_Voyage_(Hancock).jpg"
           
    };
        // Create a new user for Identity Framework
        ApplicationUser user = new ApplicationUser
        {
            FirstName = "admin",
            LastName = "admin",
            UserName = "admin@admin.com",
            NormalizedUserName = "ADMIN@ADMIN.COM",
            Email = "admin@admin.com",
            NormalizedEmail = "ADMIN@ADMIN.COM",
            EmailConfirmed = true,
            LockoutEnabled = false,
            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
            Id = "00000000-ffff-ffff-ffff-ffffffffffff"
        };
        var passwordHash = new PasswordHasher<ApplicationUser>();
        user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
        modelBuilder.Entity<ApplicationUser>().HasData(user);
    }
   }
}
