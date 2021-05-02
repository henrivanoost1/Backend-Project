using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Backend_Project.Models;
using Backend_Project.Configuration;
using System.Threading;
using System.Threading.Tasks;


namespace Backend_Project.DataContext
{
    public interface IKAJContext
    {
        DbSet<Regioverantwoordelijke> Regioverantwoordelijken { get; set; }
        DbSet<Afdeling> Afdelingen { get; set; }
        DbSet<RegioverantwoordelijkeAfdeling> RegioverantwoordelijkeAfdelingen { get; set; }
        DbSet<Gewest> Gewesten { get; set; }
        DbSet<Lid> Leden { get; set; }



        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

    public class KAJContext : DbContext, IKAJContext
    {
        public DbSet<Regioverantwoordelijke> Regioverantwoordelijken { get; set; }
        public DbSet<Afdeling> Afdelingen { get; set; }

        public DbSet<RegioverantwoordelijkeAfdeling> RegioverantwoordelijkeAfdelingen { get; set; }
        public DbSet<Gewest> Gewesten { get; set; }
        public DbSet<Lid> Leden { get; set; }


        private ConnectionStrings _connectionStrings;



        public KAJContext(DbContextOptions<KAJContext> options, IOptions<ConnectionStrings> connectionStrings) : base(options)
        {
            _connectionStrings = connectionStrings.Value;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
            options.UseSqlServer(_connectionStrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegioverantwoordelijkeAfdeling>().HasKey(sc => new { sc.RegioverantwoordelijkeId, sc.AfdelingId });

            modelBuilder.Entity<RegioverantwoordelijkeAfdeling>().HasOne<Regioverantwoordelijke>(sc => sc.Regioverantwoordelijke).WithMany(s => s.RegioverantwoordelijkeAfdelingen).HasForeignKey(sc => sc.RegioverantwoordelijkeId);
            modelBuilder.Entity<RegioverantwoordelijkeAfdeling>().HasOne<Afdeling>(sc => sc.Afdeling).WithMany(s => s.RegioverantwoordelijkeAfdelingen).HasForeignKey(sc => sc.AfdelingId);

            modelBuilder.Entity<Gewest>().HasData(new Gewest()
            {
                GewestId = 1,
                Name = "West-Vlaanderen"
            });

            modelBuilder.Entity<Gewest>().HasData(new Gewest()
            {
                GewestId = 2,
                Name = "Oost-Vlaanderen"
            });

            modelBuilder.Entity<Gewest>().HasData(new Gewest()
            {
                GewestId = 3,
                Name = "Brussel"
            });


            modelBuilder.Entity<Lid>().HasData(new Lid()
            {
                LidId = 1,
                Name = "Van Oost",
                FirstName = "Henri",
                Age = 20,
                AfdelingId = 1
            });

            modelBuilder.Entity<Lid>().HasData(new Lid()
            {
                LidId = 2,
                Name = "Van Oost",
                FirstName = "Margaux",
                Age = 22,
                AfdelingId = 1
            });

            modelBuilder.Entity<Lid>().HasData(new Lid()
            {
                LidId = 3,
                Name = "De Cocker",
                FirstName = "Simon",
                Age = 20,
                AfdelingId = 1
            });

            modelBuilder.Entity<Lid>().HasData(new Lid()
            {
                LidId = 4,
                Name = "Van Langenhove",
                FirstName = "Ina",
                Age = 19,
                AfdelingId = 2
            });

            modelBuilder.Entity<Lid>().HasData(new Lid()
            {
                LidId = 5,
                Name = "Tranchet",
                FirstName = "Britt",
                Age = 20,
                AfdelingId = 2
            });

            modelBuilder.Entity<Lid>().HasData(new Lid()
            {
                LidId = 6,
                Name = "Van Langenhove",
                FirstName = "Evy",
                Age = 16,
                AfdelingId = 2
            });

            modelBuilder.Entity<Regioverantwoordelijke>().HasData(new Regioverantwoordelijke()
            {
                RegioverantwoordelijkeId = 1,
                Name = "Sorovojo",
                FirstName = "Lina",
                Age = 23,
                Email = "lina.sorovojo@kaj.be",
                GewestId = 2
            });

            modelBuilder.Entity<Regioverantwoordelijke>().HasData(new Regioverantwoordelijke()
            {
                RegioverantwoordelijkeId = 2,
                Name = "Van Rechem",
                FirstName = "Dries",
                Age = 26,
                Email = "coordinator@kaj.be",
                GewestId = 2
            });

            modelBuilder.Entity<Regioverantwoordelijke>().HasData(new Regioverantwoordelijke()
            {
                RegioverantwoordelijkeId = 3,
                Name = "Cloet",
                FirstName = "Anke",
                Age = 24,
                Email = "anke.cloet@kaj.be",
                GewestId = 1
            });

            modelBuilder.Entity<Regioverantwoordelijke>().HasData(new Regioverantwoordelijke()
            {
                RegioverantwoordelijkeId = 4,
                Name = "Vanhoof",
                FirstName = "Lien",
                Age = 25,
                Email = "lien.vanhooft@kaj.be",
                GewestId = 1
            });

            modelBuilder.Entity<Afdeling>().HasData(new Afdeling()
            {
                AfdelingId = 1,
                Name = "KAJ Machelen",
                Gemeente = "Machelen",
                GewestId = 2
            });

            modelBuilder.Entity<Afdeling>().HasData(new Afdeling()
            {
                AfdelingId = 2,
                Name = "KAJ Merelbeke",
                Gemeente = "Merelbeke",
                GewestId = 2
            });

            modelBuilder.Entity<Afdeling>().HasData(new Afdeling()
            {
                AfdelingId = 3,
                Name = "KAJ Bottelaere",
                Gemeente = "Merelbeke",
                GewestId = 2
            });

            modelBuilder.Entity<Afdeling>().HasData(new Afdeling()
            {
                AfdelingId = 4,
                Name = "KAJ Brugge",
                Gemeente = "Brugge",
                GewestId = 1
            });

            modelBuilder.Entity<Afdeling>().HasData(new Afdeling()
            {
                AfdelingId = 5,
                Name = "KAJ Waregem",
                Gemeente = "Waregem",
                GewestId = 1
            });

            modelBuilder.Entity<Afdeling>().HasData(new Afdeling()
            {
                AfdelingId = 6,
                Name = "KAmeleJon Roeselare",
                Gemeente = "Roeselare",
                GewestId = 1
            });


            modelBuilder.Entity<Afdeling>().HasData(new Afdeling()
            {
                AfdelingId = 7,
                Name = "KAJ Don Bosco",
                Gemeente = "Sint-Pieters-Woluwe",
                GewestId = 3
            });

            modelBuilder.Entity<Afdeling>().HasData(new Afdeling()
            {
                AfdelingId = 8,
                Name = "KAJ Lajet",
                Gemeente = "Lajet",
                GewestId = 3
            });

            modelBuilder.Entity<Afdeling>().HasData(new Afdeling()
            {
                AfdelingId = 9,
                Name = "KAJ De Mug",
                Gemeente = "Brussel",
                GewestId = 3
            });

            modelBuilder.Entity<RegioverantwoordelijkeAfdeling>().HasData(new RegioverantwoordelijkeAfdeling()
            {
                RegioverantwoordelijkeAfdelingId = 1,
                RegioverantwoordelijkeId = 1,
                AfdelingId = 1
            });

            modelBuilder.Entity<RegioverantwoordelijkeAfdeling>().HasData(new RegioverantwoordelijkeAfdeling()
            {
                RegioverantwoordelijkeAfdelingId = 2,
                RegioverantwoordelijkeId = 1,
                AfdelingId = 2
            });

            modelBuilder.Entity<RegioverantwoordelijkeAfdeling>().HasData(new RegioverantwoordelijkeAfdeling()
            {
                RegioverantwoordelijkeAfdelingId = 3,
                RegioverantwoordelijkeId = 1,
                AfdelingId = 3
            });

            modelBuilder.Entity<RegioverantwoordelijkeAfdeling>().HasData(new RegioverantwoordelijkeAfdeling()
            {
                RegioverantwoordelijkeAfdelingId = 4,
                RegioverantwoordelijkeId = 2,
                AfdelingId = 1
            });

            modelBuilder.Entity<RegioverantwoordelijkeAfdeling>().HasData(new RegioverantwoordelijkeAfdeling()
            {
                RegioverantwoordelijkeAfdelingId = 5,
                RegioverantwoordelijkeId = 2,
                AfdelingId = 2
            });

            modelBuilder.Entity<RegioverantwoordelijkeAfdeling>().HasData(new RegioverantwoordelijkeAfdeling()
            {
                RegioverantwoordelijkeAfdelingId = 6,
                RegioverantwoordelijkeId = 2,
                AfdelingId = 3
            });

        }


    }
}
