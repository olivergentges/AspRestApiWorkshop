﻿// <auto-generated />
using System;
using CoreCodeCamp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreCodeCamp.Migrations
{
    [DbContext(typeof(CampContext))]
    partial class CampContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCodeCamp.Data.Camp", b =>
                {
                    b.Property<int>("CampId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EventDate");

                    b.Property<int>("Length");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Moniker");

                    b.Property<string>("Name");

                    b.HasKey("CampId");

                    b.HasIndex("LocationId");

                    b.ToTable("Camps");

                    b.HasData(
                        new
                        {
                            CampId = 1,
                            EventDate = new DateTime(2020, 06, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Length = 1,
                            LocationId = 1,
                            Moniker = "DWX2020",
                            Name = "Developer Week 20"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("Address3");

                    b.Property<string>("CityTown");

                    b.Property<string>("Country");

                    b.Property<string>("PostalCode");

                    b.Property<string>("StateProvince");

                    b.Property<string>("VenueName");

                    b.HasKey("LocationId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Address1 = "Messezentrum",
                            CityTown = "Nürnberg",
                            Country = "Germany",
                            PostalCode = "90471",
                            StateProvince = "BY",
                            VenueName = "Nürnberg Convention Center NCC Ost"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Speaker", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogUrl");

                    b.Property<string>("Company");

                    b.Property<string>("CompanyUrl");

                    b.Property<string>("FirstName");

                    b.Property<string>("GitHub");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Twitter");

                    b.HasKey("SpeakerId");

                    b.ToTable("Speakers");

                    b.HasData(
                        new
                        {
                            SpeakerId = 1,
                            BlogUrl = "http://www.cross-platform-blog.de",
                            Company = "Freier Berater, Trainer, Sprecher und Autor",
                            CompanyUrl = "http://about.me/gregor.biswanger",
                            FirstName = "Gregor",
                            GitHub = "GregorBiswanger",
                            LastName = "Biswanger",
                            Twitter = "BFreakout"
                        },
                        new
                        {
                            SpeakerId = 2,
                            BlogUrl = "http://www.cross-platform-blog.de",
                            Company = "Freie Entwicklerin",
                            CompanyUrl = "",
                            FirstName = "Christine",
                            GitHub = "",
                            LastName = "Biswanger",
                            Twitter = ""
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Talk", b =>
                {
                    b.Property<int>("TalkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abstract");

                    b.Property<int?>("CampId");

                    b.Property<int>("Level");

                    b.Property<int?>("SpeakerId");

                    b.Property<string>("Title");

                    b.HasKey("TalkId");

                    b.HasIndex("CampId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("Talks");

                    b.HasData(
                        new
                        {
                            TalkId = 1,
                            Abstract = "Wachsende Daten beanspruchen schnellere und klügere Systeme um die Datenverarbeitung bewältigen zu können.",
                            CampId = 1,
                            Level = 100,
                            SpeakerId = 1,
                            Title = "Yes, zu NoSQL mit MongoDB für .NET Entwickler!"
                        },
                        new
                        {
                            TalkId = 2,
                            Abstract = "Diese benötigen keine festgelegten Tabellenschemata, sondern haben eine ganz eigene Herangehensweise.",
                            CampId = 1,
                            Level = 200,
                            SpeakerId = 2,
                            Title = "MongoDB: Entwurfsmuster für das NoSQL-Schema Design"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Camp", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Talk", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Camp", "Camp")
                        .WithMany("Talks")
                        .HasForeignKey("CampId");

                    b.HasOne("CoreCodeCamp.Data.Speaker", "Speaker")
                        .WithMany()
                        .HasForeignKey("SpeakerId");
                });
#pragma warning restore 612, 618
        }
    }
}