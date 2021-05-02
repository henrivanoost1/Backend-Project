﻿// <auto-generated />
using Backend_Project.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend_Project.Migrations
{
    [DbContext(typeof(KAJContext))]
    [Migration("20210502010609_zevende")]
    partial class zevende
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Backend_Project.Models.Afdeling", b =>
                {
                    b.Property<int>("AfdelingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Gemeente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GewestId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AfdelingId");

                    b.HasIndex("GewestId");

                    b.ToTable("Afdelingen");

                    b.HasData(
                        new
                        {
                            AfdelingId = 1,
                            Gemeente = "Machelen",
                            GewestId = 2,
                            Name = "KAJ Machelen"
                        },
                        new
                        {
                            AfdelingId = 2,
                            Gemeente = "Merelbeke",
                            GewestId = 2,
                            Name = "KAJ Merelbeke"
                        },
                        new
                        {
                            AfdelingId = 3,
                            Gemeente = "Merelbeke",
                            GewestId = 2,
                            Name = "KAJ Bottelaere"
                        },
                        new
                        {
                            AfdelingId = 4,
                            Gemeente = "Brugge",
                            GewestId = 1,
                            Name = "KAJ Brugge"
                        },
                        new
                        {
                            AfdelingId = 5,
                            Gemeente = "Waregem",
                            GewestId = 1,
                            Name = "KAJ Waregem"
                        },
                        new
                        {
                            AfdelingId = 6,
                            Gemeente = "Roeselare",
                            GewestId = 1,
                            Name = "KAmeleJon Roeselare"
                        },
                        new
                        {
                            AfdelingId = 7,
                            Gemeente = "Sint-Pieters-Woluwe",
                            GewestId = 3,
                            Name = "KAJ Don Bosco"
                        },
                        new
                        {
                            AfdelingId = 8,
                            Gemeente = "Lajet",
                            GewestId = 3,
                            Name = "KAJ Lajet"
                        },
                        new
                        {
                            AfdelingId = 9,
                            Gemeente = "Brussel",
                            GewestId = 3,
                            Name = "KAJ De Mug"
                        });
                });

            modelBuilder.Entity("Backend_Project.Models.Gewest", b =>
                {
                    b.Property<int>("GewestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GewestId");

                    b.ToTable("Gewesten");

                    b.HasData(
                        new
                        {
                            GewestId = 1,
                            Name = "West-Vlaanderen"
                        },
                        new
                        {
                            GewestId = 2,
                            Name = "Oost-Vlaanderen"
                        },
                        new
                        {
                            GewestId = 3,
                            Name = "Brussel"
                        });
                });

            modelBuilder.Entity("Backend_Project.Models.Lid", b =>
                {
                    b.Property<int>("LidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AfdelingId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LidId");

                    b.HasIndex("AfdelingId");

                    b.ToTable("Leden");

                    b.HasData(
                        new
                        {
                            LidId = 1,
                            AfdelingId = 1,
                            Age = 20,
                            FirstName = "Henri",
                            Name = "Van Oost"
                        },
                        new
                        {
                            LidId = 2,
                            AfdelingId = 1,
                            Age = 22,
                            FirstName = "Margaux",
                            Name = "Van Oost"
                        },
                        new
                        {
                            LidId = 3,
                            AfdelingId = 1,
                            Age = 20,
                            FirstName = "Simon",
                            Name = "De Cocker"
                        },
                        new
                        {
                            LidId = 4,
                            AfdelingId = 2,
                            Age = 19,
                            FirstName = "Ina",
                            Name = "Van Langenhove"
                        },
                        new
                        {
                            LidId = 5,
                            AfdelingId = 2,
                            Age = 20,
                            FirstName = "Britt",
                            Name = "Tranchet"
                        },
                        new
                        {
                            LidId = 6,
                            AfdelingId = 2,
                            Age = 16,
                            FirstName = "Evy",
                            Name = "Van Langenhove"
                        });
                });

            modelBuilder.Entity("Backend_Project.Models.Regioverantwoordelijke", b =>
                {
                    b.Property<int>("RegioverantwoordelijkeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GewestId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegioverantwoordelijkeId");

                    b.HasIndex("GewestId");

                    b.ToTable("Regioverantwoordelijken");

                    b.HasData(
                        new
                        {
                            RegioverantwoordelijkeId = 1,
                            Age = 23,
                            Email = "lina.sorovojo@kaj.be",
                            FirstName = "Lina",
                            GewestId = 2,
                            Name = "Sorovojo"
                        },
                        new
                        {
                            RegioverantwoordelijkeId = 2,
                            Age = 26,
                            Email = "coordinator@kaj.be",
                            FirstName = "Dries",
                            GewestId = 2,
                            Name = "Van Rechem"
                        },
                        new
                        {
                            RegioverantwoordelijkeId = 3,
                            Age = 24,
                            Email = "anke.cloet@kaj.be",
                            FirstName = "Anke",
                            GewestId = 1,
                            Name = "Cloet"
                        },
                        new
                        {
                            RegioverantwoordelijkeId = 4,
                            Age = 25,
                            Email = "lien.vanhooft@kaj.be",
                            FirstName = "Lien",
                            GewestId = 1,
                            Name = "Vanhoof"
                        });
                });

            modelBuilder.Entity("Backend_Project.Models.RegioverantwoordelijkeAfdeling", b =>
                {
                    b.Property<int>("RegioverantwoordelijkeId")
                        .HasColumnType("int");

                    b.Property<int>("AfdelingId")
                        .HasColumnType("int");

                    b.HasKey("RegioverantwoordelijkeId", "AfdelingId");

                    b.HasIndex("AfdelingId");

                    b.ToTable("RegioverantwoordelijkeAfdeling");

                    b.HasData(
                        new
                        {
                            RegioverantwoordelijkeId = 1,
                            AfdelingId = 1
                        },
                        new
                        {
                            RegioverantwoordelijkeId = 1,
                            AfdelingId = 2
                        },
                        new
                        {
                            RegioverantwoordelijkeId = 1,
                            AfdelingId = 3
                        });
                });

            modelBuilder.Entity("Backend_Project.Models.Afdeling", b =>
                {
                    b.HasOne("Backend_Project.Models.Gewest", "Gewest")
                        .WithMany("Afdelingen")
                        .HasForeignKey("GewestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gewest");
                });

            modelBuilder.Entity("Backend_Project.Models.Lid", b =>
                {
                    b.HasOne("Backend_Project.Models.Afdeling", "Afdeling")
                        .WithMany("Leden")
                        .HasForeignKey("AfdelingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Afdeling");
                });

            modelBuilder.Entity("Backend_Project.Models.Regioverantwoordelijke", b =>
                {
                    b.HasOne("Backend_Project.Models.Gewest", "Gewest")
                        .WithMany("RegioverantwoordelijkeId")
                        .HasForeignKey("GewestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gewest");
                });

            modelBuilder.Entity("Backend_Project.Models.RegioverantwoordelijkeAfdeling", b =>
                {
                    b.HasOne("Backend_Project.Models.Afdeling", null)
                        .WithMany("RegioverantwoordelijkeAfdeling")
                        .HasForeignKey("AfdelingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_Project.Models.Regioverantwoordelijke", null)
                        .WithMany("RegioverantwoordelijkenAfdeling")
                        .HasForeignKey("RegioverantwoordelijkeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend_Project.Models.Afdeling", b =>
                {
                    b.Navigation("Leden");

                    b.Navigation("RegioverantwoordelijkeAfdeling");
                });

            modelBuilder.Entity("Backend_Project.Models.Gewest", b =>
                {
                    b.Navigation("Afdelingen");

                    b.Navigation("RegioverantwoordelijkeId");
                });

            modelBuilder.Entity("Backend_Project.Models.Regioverantwoordelijke", b =>
                {
                    b.Navigation("RegioverantwoordelijkenAfdeling");
                });
#pragma warning restore 612, 618
        }
    }
}