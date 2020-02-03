﻿using System;
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

            // CREATING ALBUMS FOR THE DATABASE

            Album maidenVoyage = new Album()
            {
                Id = 1,
                Title = "Maiden Voyage",
                ReleaseDate = 1965,
                Image = "https://en.wikipedia.org/wiki/File:Maiden_Voyage_(Hancock).jpg"
           
             };
            modelBuilder.Entity<Album>().HasData(maidenVoyage);

            Album pointOfDeparture = new Album()
            {
                Id = 2,
                Title = "Point Of Departure",
                ReleaseDate = 1965,
                Image = "https://en.wikipedia.org/wiki/File:Point_of_Departure.jpg"

            };
            modelBuilder.Entity<Album>().HasData(pointOfDeparture);

            Album theSoothsayer = new Album()
            {
                Id = 3,
                Title = "The Soothsayer",
                ReleaseDate = 1979,
                Image = "https://en.wikipedia.org/wiki/File:The_Soothsayer.jpg"

            };
            modelBuilder.Entity<Album>().HasData(theSoothsayer);



            // CREATING MUSICIANS FOR THE DATABASE

            Musician herbieHancock = new Musician()
            {
                Id = 1,
                Name = "Herbie Hancock",
                Instrument = "piano",
            };
            modelBuilder.Entity<Musician>().HasData(herbieHancock);

            Musician freddieHubbard = new Musician()
            {
                Id = 2,
                Name = "Freddie Hubbard",
                Instrument = "trumpet",
            };
            modelBuilder.Entity<Musician>().HasData(freddieHubbard);

            Musician georgeColeman = new Musician()
            {
                Id = 3,
                Name = "George Coleman",
                Instrument = "tenor saxophone",
            };
            modelBuilder.Entity<Musician>().HasData(georgeColeman);

            Musician ronCarter = new Musician()
            {
                Id = 4,
                Name = "Ron Carter",
                Instrument = "bass",
            };
            modelBuilder.Entity<Musician>().HasData(ronCarter);

            Musician tonyWilliams = new Musician()
            {
                Id = 5,
                Name = "Tony Williams",
                Instrument = "drums",
            };
            modelBuilder.Entity<Musician>().HasData(tonyWilliams);

            Musician kennyDorham = new Musician()
            {
                Id = 6,
                Name = "Kenny Dorham",
                Instrument = "trumpet",
            };
            modelBuilder.Entity<Musician>().HasData(kennyDorham);

            Musician ericDolphy = new Musician()
            {
                Id = 7,
                Name = "Eric Dolphy",
                Instrument = "alto saxophone",
            };
            modelBuilder.Entity<Musician>().HasData(ericDolphy);

            Musician joeHenderson = new Musician()
            {
                Id = 8,
                Name = "Joe Henderson",
                Instrument = "tenor saxophone",
            };
            modelBuilder.Entity<Musician>().HasData(joeHenderson);

            Musician andrewHill = new Musician()
            {
                Id = 9,
                Name = "Andrew Hill",
                Instrument = "piano",
            };
            modelBuilder.Entity<Musician>().HasData(andrewHill);

            Musician richardDavis = new Musician()
            {
                Id = 10,
                Name = "Richard Davis",
                Instrument = "bass",
            };
            modelBuilder.Entity<Musician>().HasData(richardDavis);

            Musician wayneShorter = new Musician()
            {
                Id = 11,
                Name = "Wayne Shorter",
                Instrument = "tenor saxophone",
            };
            modelBuilder.Entity<Musician>().HasData(wayneShorter);

            Musician jamesSpaulding = new Musician()
            {
                Id = 12,
                Name = "James Spaulding",
                Instrument = "alto saxophone",
            };
            modelBuilder.Entity<Musician>().HasData(jamesSpaulding);

            Musician mccoyTyner = new Musician()
            {
                Id = 13,
                Name = "McCoy Tyner",
                Instrument = "piano",
            };
            modelBuilder.Entity<Musician>().HasData(mccoyTyner);



            // CREATING MUSICIAN/ALBUM JOIN TABLES

            MusicianAlbum tony1 = new MusicianAlbum()
            {
                Id = 1,
                MusicianId = 5,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(tony1);

            MusicianAlbum tony2 = new MusicianAlbum()
            {
                Id = 2,
                MusicianId = 5,
                AlbumId = 2,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(tony2);

            MusicianAlbum ron1 = new MusicianAlbum()
            {
                Id = 3,
                MusicianId = 4,
                AlbumId = 1,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(ron1);

            MusicianAlbum ron2 = new MusicianAlbum()
            {
                Id = 4,
                MusicianId = 4,
                AlbumId = 3,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(ron2);


            //CREATE USER RELATED SAVED ALBUMS
            SavedAlbums save1 = new SavedAlbums()
            {
                Id = 1,
                AlbumId = 1,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbums>().HasData(save1);

            //SavedAlbums save2 = new SavedAlbums()
            //{
            //    Id = 1,
            //    AlbumId = 2,
            //    UserId = user.Id,
            //};
            //modelBuilder.Entity<SavedAlbums>().HasData(save2);

    }
   }
}
