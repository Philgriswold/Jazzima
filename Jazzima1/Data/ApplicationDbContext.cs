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
        public DbSet<SavedAlbum> SavedAlbums { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<InstrumentType> InstrumentType { get; set; }

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
                Image = "https://upload.wikimedia.org/wikipedia/en/7/7a/Maiden_Voyage_%28Hancock%29.jpg"

            };
            modelBuilder.Entity<Album>().HasData(maidenVoyage);

            Album pointOfDeparture = new Album()
            {
                Id = 2,
                Title = "Point Of Departure",
                ReleaseDate = 1965,
                Image = "https://upload.wikimedia.org/wikipedia/en/4/4a/Point_of_Departure.jpg"

            };
            modelBuilder.Entity<Album>().HasData(pointOfDeparture);

            Album theSoothsayer = new Album()
            {
                Id = 3,
                Title = "The Soothsayer",
                ReleaseDate = 1979,
                Image = "https://upload.wikimedia.org/wikipedia/en/4/41/The_Soothsayer.jpg"

            };
            modelBuilder.Entity<Album>().HasData(theSoothsayer);

            Album horaceSilverJM = new Album()
            {
                Id = 4,
                Title = "Horace Silver and The Jazz Messengers",
                ReleaseDate = 1956,
                Image = "https://upload.wikimedia.org/wikipedia/en/c/c0/Horace_Silver_and_the_Jazz_Messengers.jpg"

            };
            modelBuilder.Entity<Album>().HasData(horaceSilverJM);

            Album blueTrain = new Album()
            {
                Id = 5,
                Title = "Blue Train",
                ReleaseDate = 1958,
                Image = "https://upload.wikimedia.org/wikipedia/en/6/68/John_Coltrane_-_Blue_Train.jpg"

            };
            modelBuilder.Entity<Album>().HasData(blueTrain);

            // FOUR RECORDS FOR INSTRUMENT TYPE

            InstrumentType horn = new InstrumentType()
            {
                Id = 1,
                Description = "Horn",
            };
            modelBuilder.Entity<InstrumentType>().HasData(horn);

            InstrumentType piano = new InstrumentType()
            {
                Id = 2,
                Description = "Piano",
            };
            modelBuilder.Entity<InstrumentType>().HasData(piano);

            InstrumentType bass = new InstrumentType()
            {
                Id = 3,
                Description = "Bass",
            };
            modelBuilder.Entity<InstrumentType>().HasData(bass);

            InstrumentType drums = new InstrumentType()
            {
                Id = 4,
                Description = "Drums",
            };
            modelBuilder.Entity<InstrumentType>().HasData(drums);




            // CREATING MUSICIANS FOR THE DATABASE

            Musician herbieHancock = new Musician()
            {
                Id = 1,
                Name = "Herbie Hancock",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(herbieHancock);

            Musician freddieHubbard = new Musician()
            {
                Id = 2,
                Name = "Freddie Hubbard",
                Instrument = "trumpet",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(freddieHubbard);

            Musician georgeColeman = new Musician()
            {
                Id = 3,
                Name = "George Coleman",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(georgeColeman);

            Musician ronCarter = new Musician()
            {
                Id = 4,
                Name = "Ron Carter",
                Instrument = "bass",
                InstrumentTypeId = 3,
            };
            modelBuilder.Entity<Musician>().HasData(ronCarter);

            Musician tonyWilliams = new Musician()
            {
                Id = 5,
                Name = "Tony Williams",
                Instrument = "drums",
                InstrumentTypeId = 4,
            };
            modelBuilder.Entity<Musician>().HasData(tonyWilliams);

            Musician kennyDorham = new Musician()
            {
                Id = 6,
                Name = "Kenny Dorham",
                Instrument = "trumpet",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(kennyDorham);

            Musician ericDolphy = new Musician()
            {
                Id = 7,
                Name = "Eric Dolphy",
                Instrument = "alto saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(ericDolphy);

            Musician joeHenderson = new Musician()
            {
                Id = 8,
                Name = "Joe Henderson",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(joeHenderson);

            Musician andrewHill = new Musician()
            {
                Id = 9,
                Name = "Andrew Hill",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(andrewHill);

            Musician richardDavis = new Musician()
            {
                Id = 10,
                Name = "Richard Davis",
                Instrument = "bass",
                InstrumentTypeId = 3,
            };
            modelBuilder.Entity<Musician>().HasData(richardDavis);

            Musician wayneShorter = new Musician()
            {
                Id = 11,
                Name = "Wayne Shorter",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(wayneShorter);

            Musician jamesSpaulding = new Musician()
            {
                Id = 12,
                Name = "James Spaulding",
                Instrument = "alto saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(jamesSpaulding);

            Musician mccoyTyner = new Musician()
            {
                Id = 13,
                Name = "McCoy Tyner",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(mccoyTyner);

            Musician horaceSilver = new Musician()
            {
                Id = 14,
                Name = "Horace Silver",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(horaceSilver);

            Musician hankMobley = new Musician()
            {
                Id = 15,
                Name = "Hank Mobley",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(hankMobley);

            Musician dougWatkins = new Musician()
            {
                Id = 16,
                Name = "Doug Watkins",
                Instrument = "bass",
                InstrumentTypeId = 3,
            };
            modelBuilder.Entity<Musician>().HasData(dougWatkins);

            Musician artBlakey = new Musician()
            {
                Id = 17,
                Name = "Art Blakey",
                Instrument = "drums",
                InstrumentTypeId = 4,
            };
            modelBuilder.Entity<Musician>().HasData(artBlakey);

            Musician phillyJoeJones = new Musician()
            {
                Id = 18,
                Name = "Philly Joe Jones",
                Instrument = "drums",
                InstrumentTypeId = 4,
            };
            modelBuilder.Entity<Musician>().HasData(phillyJoeJones);

            Musician paulChambers = new Musician()
            {
                Id = 19,
                Name = "Paul Chambers",
                Instrument = "bass",
                InstrumentTypeId = 3,
            };
            modelBuilder.Entity<Musician>().HasData(paulChambers);

            Musician kennyDrew = new Musician()
            {
                Id = 20,
                Name = "Kenny Drew",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(kennyDrew);

            Musician curtisFuller = new Musician()
            {
                Id = 21,
                Name = "Curtis Fuller",
                Instrument = "trombone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(curtisFuller);

            Musician leeMorgan = new Musician()
            {
                Id = 22,
                Name = "Lee Morgan",
                Instrument = "trumpet",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(leeMorgan);

            Musician johnColtrane = new Musician()
            {
                Id = 19,
                Name = "John Coltrane",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(johnColtrane);



            // CREATING MUSICIAN/ALBUM JOIN TABLES
            MusicianAlbum herbieMaidenVoyage = new MusicianAlbum()
            {
                Id = 1,
                MusicianId = 1,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(herbieMaidenVoyage);

            MusicianAlbum freddieMaidenVoyage = new MusicianAlbum()
            {
                Id = 2,
                MusicianId = 2,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(freddieMaidenVoyage);

            MusicianAlbum freddieTheSoothsayer = new MusicianAlbum()
            {
                Id = 3,
                MusicianId = 2,
                AlbumId = theSoothsayer.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(freddieTheSoothsayer);

            MusicianAlbum georgeMaidenVoyage = new MusicianAlbum()
            {
                Id = 4,
                MusicianId = 3,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(georgeMaidenVoyage);

            MusicianAlbum kennyPointOfDeparture = new MusicianAlbum()
            {
                Id = 5,
                MusicianId = 6,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(kennyPointOfDeparture);

            MusicianAlbum ericPointOfDeparture = new MusicianAlbum()
            {
                Id = 6,
                MusicianId = 7,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(ericPointOfDeparture);

            MusicianAlbum joePointOfDeparture = new MusicianAlbum()
            {
                Id = 7,
                MusicianId = 8,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(joePointOfDeparture);

            MusicianAlbum andrewPointOfDeparture = new MusicianAlbum()
            {
                Id = 8,
                MusicianId = 9,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(andrewPointOfDeparture);

            MusicianAlbum richardPointOfDeparture = new MusicianAlbum()
            {
                Id = 9,
                MusicianId = 10,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(richardPointOfDeparture);

            MusicianAlbum wayneTheSoothsayer = new MusicianAlbum()
            {
                Id = 10,
                MusicianId = 11,
                AlbumId = theSoothsayer.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(wayneTheSoothsayer);

            MusicianAlbum jamesTheSoothsayer = new MusicianAlbum()
            {
                Id = 11,
                MusicianId = 12,
                AlbumId = theSoothsayer.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(jamesTheSoothsayer);

            MusicianAlbum mccoyTheSoothsayer = new MusicianAlbum()
            {
                Id = 12,
                MusicianId = 13,
                AlbumId = theSoothsayer.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(mccoyTheSoothsayer);


            MusicianAlbum tonyMaidenVoyage = new MusicianAlbum()
            {
                Id = 13,
                MusicianId = 5,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(tonyMaidenVoyage);

            MusicianAlbum tonyPointOfDeparture = new MusicianAlbum()
            {
                Id = 14,
                MusicianId = 5,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(tonyPointOfDeparture);

            MusicianAlbum ronMaidenVoyage = new MusicianAlbum()
            {
                Id = 15,
                MusicianId = 4,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(ronMaidenVoyage);

            MusicianAlbum ronTheSoothsayer = new MusicianAlbum()
            {
                Id = 16,
                MusicianId = 4,
                AlbumId = theSoothsayer.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(ronTheSoothsayer);

            MusicianAlbum horaceHorace = new MusicianAlbum()
            {
                Id = 17,
                MusicianId = 14,
                AlbumId = horaceSilverJM.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(horaceHorace);

            MusicianAlbum kennyHorace = new MusicianAlbum()
            {
                Id = 18,
                MusicianId = 6,
                AlbumId = horaceSilverJM.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(kennyHorace);

            MusicianAlbum hankHorace = new MusicianAlbum()
            {
                Id = 19,
                MusicianId = 15,
                AlbumId = horaceSilverJM.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(hankHorace);

            MusicianAlbum dougHorace = new MusicianAlbum()
            {
                Id = 20,
                MusicianId = 16,
                AlbumId = horaceSilverJM.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(dougHorace);

            MusicianAlbum artHorace = new MusicianAlbum()
            {
                Id = 21,
                MusicianId = 17,
                AlbumId = horaceSilverJM.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(artHorace);






            //CREATE USER RELATED SAVED ALBUMS
            SavedAlbum save1 = new SavedAlbum()
            {
                Id = 1,
                AlbumId = 1,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save1);

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
