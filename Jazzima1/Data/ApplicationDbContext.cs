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

            Album theCooker = new Album()
            {
                Id = 6,
                Title = "The Cooker",
                ReleaseDate = 1958,
                Image = "https://upload.wikimedia.org/wikipedia/en/e/ec/The_Cooker.jpg"

            };
            modelBuilder.Entity<Album>().HasData(theCooker);

            Album somethinElse = new Album()
            {
                Id = 7,
                Title = "Somethin' Else",
                ReleaseDate = 1958,
                Image = "https://upload.wikimedia.org/wikipedia/commons/a/ad/Somethin%E2%80%99_Else.jpg"

            };
            modelBuilder.Entity<Album>().HasData(somethinElse);

            Album newksTime = new Album()
            {
                Id = 8,
                Title = "Newk's Time",
                ReleaseDate = 1959,
                Image = "https://upload.wikimedia.org/wikipedia/en/3/32/Newk%27s_Time.jpeg"

            };
            modelBuilder.Entity<Album>().HasData(newksTime);

            Album offToTheRaces = new Album()
            {
                Id = 9,
                Title = "Off To The Races",
                ReleaseDate = 1959,
                Image = "https://upload.wikimedia.org/wikipedia/en/0/0e/Off_to_the_Races.jpg"

            };
            modelBuilder.Entity<Album>().HasData(offToTheRaces);

            Album newSoil = new Album()
            {
                Id = 10,
                Title = "New Soil",
                ReleaseDate = 1959,
                Image = "https://upload.wikimedia.org/wikipedia/en/7/78/New_Soil.jpg"

            };
            modelBuilder.Entity<Album>().HasData(newSoil);

            Album davisCup = new Album()
            {
                Id = 11,
                Title = "Davis Cup",
                ReleaseDate = 1960,
                Image = "https://upload.wikimedia.org/wikipedia/en/f/f1/Davis_Cup_%28album%29.jpg"

            };
            modelBuilder.Entity<Album>().HasData(davisCup);

            Album openSesame= new Album()
            {
                Id = 12,
                Title = "Open Sesame",
                ReleaseDate = 1960,
                Image = "https://upload.wikimedia.org/wikipedia/en/d/d1/Open_Sesame_%28Freddie_Hubbard_album%29.jpg"

            };
            modelBuilder.Entity<Album>().HasData(openSesame);

            Album atsDelight = new Album()
            {
                Id = 13,
                Title = "A.T's Delight",
                ReleaseDate = 1960,
                Image = "https://upload.wikimedia.org/wikipedia/en/9/94/AT%27s_Delight.jpg"

            };
            modelBuilder.Entity<Album>().HasData(atsDelight);




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


            Musician null1 = new Musician()
            {
                Id = 1,
                Name = null,
                Instrument = "horns",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(null1);

            Musician null2 = new Musician()
            {
                Id = 2,
                Name = null,
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(null2);

            Musician null3 = new Musician()
            {
                Id = 3,
                Name = null,
                Instrument = "bass",
                InstrumentTypeId = 3,
            };
            modelBuilder.Entity<Musician>().HasData(null3);

            Musician null4 = new Musician()
            {
                Id = 4,
                Name = null,
                Instrument = "drums",
                InstrumentTypeId = 4,
            };
            modelBuilder.Entity<Musician>().HasData(null4);

            Musician herbieHancock = new Musician()
            {
                Id = 5,
                Name = "Herbie Hancock",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(herbieHancock);

            Musician freddieHubbard = new Musician()
            {
                Id = 6,
                Name = "Freddie Hubbard",
                Instrument = "trumpet",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(freddieHubbard);

            Musician georgeColeman = new Musician()
            {
                Id = 7,
                Name = "George Coleman",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(georgeColeman);

            Musician ronCarter = new Musician()
            {
                Id = 8,
                Name = "Ron Carter",
                Instrument = "bass",
                InstrumentTypeId = 3,
            };
            modelBuilder.Entity<Musician>().HasData(ronCarter);

            Musician tonyWilliams = new Musician()
            {
                Id = 9,
                Name = "Tony Williams",
                Instrument = "drums",
                InstrumentTypeId = 4,
            };
            modelBuilder.Entity<Musician>().HasData(tonyWilliams);

            Musician kennyDorham = new Musician()
            {
                Id = 10,
                Name = "Kenny Dorham",
                Instrument = "trumpet",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(kennyDorham);

            Musician ericDolphy = new Musician()
            {
                Id = 11,
                Name = "Eric Dolphy",
                Instrument = "alto saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(ericDolphy);

            Musician joeHenderson = new Musician()
            {
                Id = 12,
                Name = "Joe Henderson",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(joeHenderson);

            Musician andrewHill = new Musician()
            {
                Id = 13,
                Name = "Andrew Hill",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(andrewHill);

            Musician richardDavis = new Musician()
            {
                Id = 14,
                Name = "Richard Davis",
                Instrument = "bass",
                InstrumentTypeId = 3,
            };
            modelBuilder.Entity<Musician>().HasData(richardDavis);

            Musician wayneShorter = new Musician()
            {
                Id = 15,
                Name = "Wayne Shorter",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(wayneShorter);

            Musician jamesSpaulding = new Musician()
            {
                Id = 16,
                Name = "James Spaulding",
                Instrument = "alto saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(jamesSpaulding);

            Musician mccoyTyner = new Musician()
            {
                Id = 17,
                Name = "McCoy Tyner",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(mccoyTyner);

            Musician horaceSilver = new Musician()
            {
                Id = 18,
                Name = "Horace Silver",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(horaceSilver);

            Musician hankMobley = new Musician()
            {
                Id = 19,
                Name = "Hank Mobley",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(hankMobley);

            Musician dougWatkins = new Musician()
            {
                Id = 20,
                Name = "Doug Watkins",
                Instrument = "bass",
                InstrumentTypeId = 3,
            };
            modelBuilder.Entity<Musician>().HasData(dougWatkins);

            Musician artBlakey = new Musician()
            {
                Id = 21,
                Name = "Art Blakey",
                Instrument = "drums",
                InstrumentTypeId = 4,
            };
            modelBuilder.Entity<Musician>().HasData(artBlakey);

            Musician phillyJoeJones = new Musician()
            {
                Id = 22,
                Name = "Philly Joe Jones",
                Instrument = "drums",
                InstrumentTypeId = 4,
            };
            modelBuilder.Entity<Musician>().HasData(phillyJoeJones);

            Musician paulChambers = new Musician()
            {
                Id = 23,
                Name = "Paul Chambers",
                Instrument = "bass",
                InstrumentTypeId = 3,
            };
            modelBuilder.Entity<Musician>().HasData(paulChambers);

            Musician kennyDrew = new Musician()
            {
                Id = 24,
                Name = "Kenny Drew",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(kennyDrew);

            Musician curtisFuller = new Musician()
            {
                Id = 25,
                Name = "Curtis Fuller",
                Instrument = "trombone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(curtisFuller);

            Musician leeMorgan = new Musician()
            {
                Id = 26,
                Name = "Lee Morgan",
                Instrument = "trumpet",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(leeMorgan);

            Musician johnColtrane = new Musician()
            {
                Id = 27,
                Name = "John Coltrane",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(johnColtrane);

            Musician bobbyTimmons = new Musician()
            {
                Id = 28,
                Name = "Bobby Timmons",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(bobbyTimmons);

            Musician pepperAdams = new Musician()
            {
                Id = 29,
                Name = "Pepper Adams",
                Instrument = "baritone saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(pepperAdams);

            Musician cannonballAdderley= new Musician()
            {
                Id = 30,
                Name = "Cannonball Adderley",
                Instrument = "alto saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(cannonballAdderley);

            Musician milesDavis = new Musician()
            {
                Id = 31,
                Name = "Miles Davis",
                Instrument = "trumpet",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(milesDavis);

            Musician hankJones = new Musician()
            {
                Id = 32,
                Name = "Hank Jones",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(hankJones);

            Musician samJonesPiano = new Musician()
            {
                Id = 33,
                Name = "Sam Jones",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(samJonesPiano);


            Musician sonnyRollins = new Musician()
            {
                Id = 34,
                Name = "Sonny Rollins",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(sonnyRollins);

            Musician wyntonKelly = new Musician()
            {
                Id = 35,
                Name = "Wynton Kelly",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(wyntonKelly);

            Musician donaldByrd = new Musician()
            {
                Id = 36,
                Name = "Donald Byrd",
                Instrument = "trumpet",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(donaldByrd);

            Musician jackieMclean = new Musician()
            {
                Id = 37,
                Name = "Jackie McLean",
                Instrument = "alto saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(jackieMclean);

            Musician samJonesBass  = new Musician()
            {
                Id = 38,
                Name = "Sam Jones",
                Instrument = "bass",
                InstrumentTypeId = 3,
            };
            modelBuilder.Entity<Musician>().HasData(samJonesBass);

            Musician artTaylor = new Musician()
            {
                Id = 39,
                Name = "Art Taylor",
                Instrument = "drums",
                InstrumentTypeId = 4,
            };
            modelBuilder.Entity<Musician>().HasData(artTaylor);

            Musician walterDavis = new Musician()
            {
                Id = 40,
                Name = "Walter Davis Jr.",
                Instrument = "piano",
                InstrumentTypeId = 2,
            };
            modelBuilder.Entity<Musician>().HasData(walterDavis);

            Musician peteLaRoca = new Musician()
            {
                Id = 41,
                Name = "Pete La Roca",
                Instrument = "drums",
                InstrumentTypeId = 4,
            };
            modelBuilder.Entity<Musician>().HasData(peteLaRoca);

            Musician cliffordJarvis = new Musician()
            {
                Id = 42,
                Name = "Clifford Jarvis",
                Instrument = "drums",
                InstrumentTypeId = 4,
            };
            modelBuilder.Entity<Musician>().HasData(cliffordJarvis);

            Musician stanleyTurrentine = new Musician()
            {
                Id = 43,
                Name = "Stanley Turrentine",
                Instrument = "tenor saxophone",
                InstrumentTypeId = 1,
            };
            modelBuilder.Entity<Musician>().HasData(stanleyTurrentine);






            // CREATING MUSICIAN/ALBUM JOIN TABLES
            MusicianAlbum herbieMaidenVoyage = new MusicianAlbum()
            {
                Id = 1,
                MusicianId = 5,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(herbieMaidenVoyage);

            MusicianAlbum freddieMaidenVoyage = new MusicianAlbum()
            {
                Id = 2,
                MusicianId = 6,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(freddieMaidenVoyage);

            MusicianAlbum freddieTheSoothsayer = new MusicianAlbum()
            {
                Id = 3,
                MusicianId = 6,
                AlbumId = theSoothsayer.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(freddieTheSoothsayer);

            MusicianAlbum georgeMaidenVoyage = new MusicianAlbum()
            {
                Id = 4,
                MusicianId = 7,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(georgeMaidenVoyage);

            MusicianAlbum kennyPointOfDeparture = new MusicianAlbum()
            {
                Id = 5,
                MusicianId = 10,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(kennyPointOfDeparture);

            MusicianAlbum ericPointOfDeparture = new MusicianAlbum()
            {
                Id = 6,
                MusicianId = 11,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(ericPointOfDeparture);

            MusicianAlbum joePointOfDeparture = new MusicianAlbum()
            {
                Id = 7,
                MusicianId = 12,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(joePointOfDeparture);

            MusicianAlbum andrewPointOfDeparture = new MusicianAlbum()
            {
                Id = 8,
                MusicianId = 13,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(andrewPointOfDeparture);

            MusicianAlbum richardPointOfDeparture = new MusicianAlbum()
            {
                Id = 9,
                MusicianId = 14,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(richardPointOfDeparture);

            MusicianAlbum wayneTheSoothsayer = new MusicianAlbum()
            {
                Id = 10,
                MusicianId = 15,
                AlbumId = theSoothsayer.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(wayneTheSoothsayer);

            MusicianAlbum jamesTheSoothsayer = new MusicianAlbum()
            {
                Id = 11,
                MusicianId = 16,
                AlbumId = theSoothsayer.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(jamesTheSoothsayer);

            MusicianAlbum mccoyTheSoothsayer = new MusicianAlbum()
            {
                Id = 12,
                MusicianId = 17,
                AlbumId = theSoothsayer.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(mccoyTheSoothsayer);


            MusicianAlbum tonyMaidenVoyage = new MusicianAlbum()
            {
                Id = 13,
                MusicianId = 9,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(tonyMaidenVoyage);

            MusicianAlbum tonyPointOfDeparture = new MusicianAlbum()
            {
                Id = 14,
                MusicianId = 9,
                AlbumId = pointOfDeparture.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(tonyPointOfDeparture);

            MusicianAlbum ronMaidenVoyage = new MusicianAlbum()
            {
                Id = 15,
                MusicianId = 8,
                AlbumId = maidenVoyage.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(ronMaidenVoyage);

            MusicianAlbum ronTheSoothsayer = new MusicianAlbum()
            {
                Id = 16,
                MusicianId = 8,
                AlbumId = theSoothsayer.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(ronTheSoothsayer);

            MusicianAlbum horaceHorace = new MusicianAlbum()
            {
                Id = 17,
                MusicianId = 18,
                AlbumId = horaceSilverJM.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(horaceHorace);

            MusicianAlbum kennyHorace = new MusicianAlbum()
            {
                Id = 18,
                MusicianId = 10,
                AlbumId = horaceSilverJM.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(kennyHorace);

            MusicianAlbum hankHorace = new MusicianAlbum()
            {
                Id = 19,
                MusicianId = 19,
                AlbumId = horaceSilverJM.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(hankHorace);

            MusicianAlbum dougHorace = new MusicianAlbum()
            {
                Id = 20,
                MusicianId = 20,
                AlbumId = horaceSilverJM.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(dougHorace);

            MusicianAlbum artHorace = new MusicianAlbum()
            {
                Id = 21,
                MusicianId = 21,
                AlbumId = horaceSilverJM.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(artHorace);

            MusicianAlbum johnBlueTrain = new MusicianAlbum()
            {
                Id = 22,
                MusicianId = 27,
                AlbumId = blueTrain.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(johnBlueTrain);

            MusicianAlbum curtisBlueTrain = new MusicianAlbum()
            {
                Id = 23,
                MusicianId = 25,
                AlbumId = blueTrain.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(curtisBlueTrain);

            MusicianAlbum kennyBlueTrain = new MusicianAlbum()
            {
                Id = 24,
                MusicianId = 24,
                AlbumId = blueTrain.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(kennyBlueTrain);

            MusicianAlbum leeBlueTrain = new MusicianAlbum()
            {
                Id = 25,
                MusicianId = 26,
                AlbumId = blueTrain.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(leeBlueTrain);

            MusicianAlbum paulBlueTrain = new MusicianAlbum()
            {
                Id = 26,
                MusicianId = 23,
                AlbumId = blueTrain.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(paulBlueTrain);

            MusicianAlbum phillyJoeBlueTrain = new MusicianAlbum()
            {
                Id = 27,
                MusicianId = 22,
                AlbumId = blueTrain.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(phillyJoeBlueTrain);

            MusicianAlbum leeTheCooker = new MusicianAlbum()
            {
                Id = 28,
                MusicianId = 26,
                AlbumId = theCooker.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(leeTheCooker);

            MusicianAlbum pepperTheCooker = new MusicianAlbum()
            {
                Id = 29,
                MusicianId = 29,
                AlbumId = theCooker.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(pepperTheCooker);

            MusicianAlbum bobbyTheCooker = new MusicianAlbum()
            {
                Id = 30,
                MusicianId = 28,
                AlbumId = theCooker.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(bobbyTheCooker);

            MusicianAlbum paulTheCooker = new MusicianAlbum()
            {
                Id = 31,
                MusicianId = 23,
                AlbumId = theCooker.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(paulTheCooker);

            MusicianAlbum phillyJoeTheCooker = new MusicianAlbum()
            {
                Id = 32,
                MusicianId = 22,
                AlbumId = theCooker.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(phillyJoeTheCooker);

            MusicianAlbum cannonballSE = new MusicianAlbum()
            {
                Id = 33,
                MusicianId = 30,
                AlbumId = somethinElse.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(cannonballSE);

            MusicianAlbum milesSE = new MusicianAlbum()
            {
                Id = 34,
                MusicianId = 31,
                AlbumId = somethinElse.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(milesSE);

            MusicianAlbum hankSE = new MusicianAlbum()
            {
                Id = 35,
                MusicianId = 32,
                AlbumId = somethinElse.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(hankSE);

            MusicianAlbum samSE = new MusicianAlbum()
            {
                Id = 36,
                MusicianId = 33,
                AlbumId = somethinElse.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(samSE);

            MusicianAlbum artSE = new MusicianAlbum()
            {
                Id = 37,
                MusicianId = 21,
                AlbumId = somethinElse.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(artSE);

            MusicianAlbum sonnyNewksTime = new MusicianAlbum()
            {
                Id = 38,
                MusicianId = 34,
                AlbumId = newksTime.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(sonnyNewksTime);

            MusicianAlbum wyntonNewksTime = new MusicianAlbum()
            {
                Id = 39,
                MusicianId = 35,
                AlbumId = newksTime.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(wyntonNewksTime);

            MusicianAlbum dougNewksTime = new MusicianAlbum()
            {
                Id = 40,
                MusicianId = 20,
                AlbumId = newksTime.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(dougNewksTime);

            MusicianAlbum phillyJoeNewksTime = new MusicianAlbum()
            {
                Id = 41,
                MusicianId = 22,
                AlbumId = newksTime.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(phillyJoeNewksTime);

            MusicianAlbum donaldOff = new MusicianAlbum()
            {
                Id = 42,
                MusicianId = 36,
                AlbumId = offToTheRaces.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(donaldOff);

            MusicianAlbum jackieOff = new MusicianAlbum()
            {
                Id = 43,
                MusicianId = 37,
                AlbumId = offToTheRaces.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(jackieOff);

            MusicianAlbum pepperOff = new MusicianAlbum()
            {
                Id = 44,
                MusicianId = 29,
                AlbumId = offToTheRaces.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(pepperOff);

            MusicianAlbum wyntonOff = new MusicianAlbum()
            {
                Id = 45,
                MusicianId = 35,
                AlbumId = offToTheRaces.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(wyntonOff);

            MusicianAlbum samOff = new MusicianAlbum()
            {
                Id = 46,
                MusicianId = 38,
                AlbumId = offToTheRaces.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(samOff);

            MusicianAlbum artOff = new MusicianAlbum()
            {
                Id = 47,
                MusicianId = 39,
                AlbumId = offToTheRaces.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(artOff);

            MusicianAlbum jackieNewSoil = new MusicianAlbum()
            {
                Id = 48,
                MusicianId = 37,
                AlbumId = newSoil.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(jackieNewSoil);

            MusicianAlbum donaldNewSoil = new MusicianAlbum()
            {
                Id = 49,
                MusicianId = 36,
                AlbumId = newSoil.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(donaldNewSoil);

            MusicianAlbum walterNewSoil = new MusicianAlbum()
            {
                Id = 50,
                MusicianId = 40,
                AlbumId = newSoil.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(walterNewSoil);

            MusicianAlbum paulNewSoil = new MusicianAlbum()
            {
                Id = 51,
                MusicianId = 23,
                AlbumId = newSoil.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(paulNewSoil);

            MusicianAlbum peteNewSoil = new MusicianAlbum()
            {
                Id = 52,
                MusicianId = 41,
                AlbumId = newSoil.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(peteNewSoil);

            MusicianAlbum walterDavisCup = new MusicianAlbum()
            {
                Id = 53,
                MusicianId = 40,
                AlbumId = davisCup.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(walterDavisCup);

            MusicianAlbum donaldDavisCup = new MusicianAlbum()
            {
                Id = 54,
                MusicianId = 36,
                AlbumId = davisCup.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(donaldDavisCup);

            MusicianAlbum jackieDavisCup = new MusicianAlbum()
            {
                Id = 55,
                MusicianId = 37,
                AlbumId = davisCup.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(jackieDavisCup);

            MusicianAlbum samDavisCup = new MusicianAlbum()
            {
                Id = 56,
                MusicianId = 38,
                AlbumId = davisCup.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(samDavisCup);

            MusicianAlbum artDavisCup = new MusicianAlbum()
            {
                Id = 57,
                MusicianId = 39,
                AlbumId = davisCup.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(artDavisCup);

            MusicianAlbum freddieOpenSesame = new MusicianAlbum()
            {
                Id = 58,
                MusicianId = 6,
                AlbumId = openSesame.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(freddieOpenSesame);

            MusicianAlbum mccoyOpenSesame = new MusicianAlbum()
            {
                Id = 59,
                MusicianId = 17,
                AlbumId = openSesame.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(mccoyOpenSesame);

            MusicianAlbum samOpenSesame = new MusicianAlbum()
            {
                Id = 60,
                MusicianId = 38,
                AlbumId = openSesame.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(samOpenSesame);

            MusicianAlbum cliffordOpenSesame = new MusicianAlbum()
            {
                Id = 61,
                MusicianId = 42,
                AlbumId = openSesame.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(cliffordOpenSesame);

            MusicianAlbum stanleyAtsDelight = new MusicianAlbum()
            {
                Id = 62,
                MusicianId = 43,
                AlbumId = atsDelight.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(stanleyAtsDelight);

            MusicianAlbum wyntonAtsDelight = new MusicianAlbum()
            {
                Id = 63,
                MusicianId = 35,
                AlbumId = atsDelight.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(wyntonAtsDelight);

            MusicianAlbum paulAtsDelight = new MusicianAlbum()
            {
                Id = 64,
                MusicianId = 23,
                AlbumId = atsDelight.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(paulAtsDelight);

            MusicianAlbum artAtsDelight = new MusicianAlbum()
            {
                Id = 65,
                MusicianId = 39,
                AlbumId = atsDelight.Id,
            };
            modelBuilder.Entity<MusicianAlbum>().HasData(artAtsDelight);

       




            //CREATE USER RELATED SAVED ALBUMS
            SavedAlbum save1 = new SavedAlbum()
            {
                Id = 1,
                AlbumId = 1,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save1);

            SavedAlbum save2 = new SavedAlbum()
            {
                Id = 2,
                AlbumId = 2,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save2);

            SavedAlbum save3 = new SavedAlbum()
            {
                Id = 3,
                AlbumId = 3,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save3);

            SavedAlbum save4 = new SavedAlbum()
            {
                Id = 4,
                AlbumId = 4,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save4);

            SavedAlbum save5 = new SavedAlbum()
            {
                Id = 5,
                AlbumId = 5,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save5);

            SavedAlbum save6 = new SavedAlbum()
            {
                Id = 6,
                AlbumId = 6,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save6);


            SavedAlbum save7 = new SavedAlbum()
            {
                Id = 7,
                AlbumId = 7,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save7);


            SavedAlbum save8 = new SavedAlbum()
            {
                Id = 8,
                AlbumId = 8,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save8);


            SavedAlbum save9 = new SavedAlbum()
            {
                Id = 9,
                AlbumId = 9,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save9);


            SavedAlbum save10 = new SavedAlbum()
            {
                Id = 10,
                AlbumId = 10,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save10);


            SavedAlbum save11 = new SavedAlbum()
            {
                Id = 11,
                AlbumId = 11,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save11);


            SavedAlbum save12 = new SavedAlbum()
            {
                Id = 12,
                AlbumId = 12,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save12);


            SavedAlbum save13 = new SavedAlbum()
            {
                Id = 13,
                AlbumId = 13,
                UserId = user.Id,
            };
            modelBuilder.Entity<SavedAlbum>().HasData(save13);

        }
    }
}
