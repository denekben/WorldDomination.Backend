﻿// <auto-generated />
using System;
using Game.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Game.Infrastructure.Migrations
{
    [DbContext(typeof(GameWriteDbContext))]
    partial class GameWriteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Game")
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Game.Domain.CountryAggregate.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("CityImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uuid");

                    b.Property<int>("DevelopmentLevel")
                        .HasColumnType("integer");

                    b.Property<bool>("HaveShield")
                        .HasColumnType("boolean");

                    b.Property<int>("Income")
                        .HasColumnType("integer");

                    b.Property<bool>("IsAlive")
                        .HasColumnType("boolean");

                    b.Property<int>("LivingLevel")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities", "Game");
                });

            modelBuilder.Entity("Game.Domain.CountryAggregate.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int>("Budget")
                        .HasColumnType("integer");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FlagImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uuid");

                    b.Property<bool>("HaveNuclearTechnology")
                        .HasColumnType("boolean");

                    b.Property<int>("LivingLevel")
                        .HasColumnType("integer");

                    b.Property<int>("NuclearTechnology")
                        .HasColumnType("integer");

                    b.Property<int>("SanctionCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Countries", "Game");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.RoomAggregate.Abstractions.RoomMember", b =>
                {
                    b.Property<Guid>("GameUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CountryId")
                        .HasColumnType("uuid");

                    b.Property<string>("GameRole")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProfileImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoomMemberRole")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.HasKey("GameUserId", "RoomId");

                    b.HasIndex("CountryId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomMembers", "Game");

                    b.HasDiscriminator<string>("RoomMemberRole").HasValue("RoomMember");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Game.Domain.GameAggregate.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int>("CurrentRound")
                        .HasColumnType("integer");

                    b.Property<int>("EcologyLevel")
                        .HasColumnType("integer");

                    b.Property<string>("GameType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoomId")
                        .IsUnique();

                    b.ToTable("Games", "Game");
                });

            modelBuilder.Entity("Game.Domain.RoomAggregate.Entities.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int>("CountryQuantity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2024, 10, 29, 13, 59, 32, 992, DateTimeKind.Utc).AddTicks(8429));

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("GameType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("boolean");

                    b.Property<string>("RoomCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoomMemberLimit")
                        .HasColumnType("integer");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Rooms", "Game");
                });

            modelBuilder.Entity("Game.Domain.UserAggregate.Entities.GameUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProfileImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GameUsers", "Game");
                });

            modelBuilder.Entity("Game.Infrastructure.Seed.CityPattern", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("CityImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("CityPatterns", "Game");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6e137a7b-d279-412b-984c-2425a06704f4"),
                            CityImagePath = "",
                            CityName = "Москва",
                            CountryId = new Guid("121ba607-2ca9-4766-8483-405db23ccd1a")
                        },
                        new
                        {
                            Id = new Guid("5ebd765a-7b24-4567-a138-98e1956d1a06"),
                            CityImagePath = "",
                            CityName = "Санкт-Петербург",
                            CountryId = new Guid("121ba607-2ca9-4766-8483-405db23ccd1a")
                        },
                        new
                        {
                            Id = new Guid("d2e36b23-5ff7-4df0-aa5c-0ba96c644a29"),
                            CityImagePath = "",
                            CityName = "Екатеринбург",
                            CountryId = new Guid("121ba607-2ca9-4766-8483-405db23ccd1a")
                        },
                        new
                        {
                            Id = new Guid("5f5738b3-4d02-4d08-9869-0fe6bc6c1cdf"),
                            CityImagePath = "",
                            CityName = "Новосибирск",
                            CountryId = new Guid("121ba607-2ca9-4766-8483-405db23ccd1a")
                        },
                        new
                        {
                            Id = new Guid("c16b0f41-4075-4537-b07a-38796a27bec8"),
                            CityImagePath = "",
                            CityName = "Пекин",
                            CountryId = new Guid("10f3f392-b035-4031-bd25-289273b99d0c")
                        },
                        new
                        {
                            Id = new Guid("e9d05b6f-fc0b-49a5-b468-d7f814b8aa58"),
                            CityImagePath = "",
                            CityName = "Шанхай",
                            CountryId = new Guid("10f3f392-b035-4031-bd25-289273b99d0c")
                        },
                        new
                        {
                            Id = new Guid("c4002b06-8a57-4c95-ac94-7123fd2ac469"),
                            CityImagePath = "",
                            CityName = "Чунцин",
                            CountryId = new Guid("10f3f392-b035-4031-bd25-289273b99d0c")
                        },
                        new
                        {
                            Id = new Guid("cbe65655-65b1-4ecf-90b4-73cc1625d2f4"),
                            CityImagePath = "",
                            CityName = "Тяньцзинь",
                            CountryId = new Guid("10f3f392-b035-4031-bd25-289273b99d0c")
                        },
                        new
                        {
                            Id = new Guid("b536243a-bd0f-4ae5-9a4f-fd0376c8019d"),
                            CityImagePath = "",
                            CityName = "Токио",
                            CountryId = new Guid("a96b3639-4c39-40b7-a248-b39b35b13b34")
                        },
                        new
                        {
                            Id = new Guid("d23c2976-72b0-476c-80a9-9d05c3d7bbac"),
                            CityImagePath = "",
                            CityName = "Йокогама",
                            CountryId = new Guid("a96b3639-4c39-40b7-a248-b39b35b13b34")
                        },
                        new
                        {
                            Id = new Guid("7116b054-f89a-4c16-bc7c-6f68c879051d"),
                            CityImagePath = "",
                            CityName = "Осака",
                            CountryId = new Guid("a96b3639-4c39-40b7-a248-b39b35b13b34")
                        },
                        new
                        {
                            Id = new Guid("7dfde91b-5b5a-43e3-a255-4e52fdf6f2c7"),
                            CityImagePath = "",
                            CityName = "Нагоя",
                            CountryId = new Guid("a96b3639-4c39-40b7-a248-b39b35b13b34")
                        },
                        new
                        {
                            Id = new Guid("145fd29f-dac1-4ff2-832a-87acf35718bd"),
                            CityImagePath = "",
                            CityName = "Берлин",
                            CountryId = new Guid("b00a5af6-6cec-464c-9e62-a75f1d97e247")
                        },
                        new
                        {
                            Id = new Guid("1d251f07-6024-441c-a3bc-73b024b08591"),
                            CityImagePath = "",
                            CityName = "Гамбург",
                            CountryId = new Guid("b00a5af6-6cec-464c-9e62-a75f1d97e247")
                        },
                        new
                        {
                            Id = new Guid("4f08c652-13af-4812-9be3-345b8b1464e8"),
                            CityImagePath = "",
                            CityName = "Мюнхен",
                            CountryId = new Guid("b00a5af6-6cec-464c-9e62-a75f1d97e247")
                        },
                        new
                        {
                            Id = new Guid("dcd400f6-c260-454e-9222-93da22d36039"),
                            CityImagePath = "",
                            CityName = "Кёльн",
                            CountryId = new Guid("b00a5af6-6cec-464c-9e62-a75f1d97e247")
                        },
                        new
                        {
                            Id = new Guid("3549d4f3-59c6-410b-bf62-eb868c21953b"),
                            CityImagePath = "",
                            CityName = "Париж",
                            CountryId = new Guid("754228ff-d1d4-46b9-8dd0-fcf33f99ea73")
                        },
                        new
                        {
                            Id = new Guid("506a3ef4-3872-47b3-a396-30d5fa873788"),
                            CityImagePath = "",
                            CityName = "Марсель",
                            CountryId = new Guid("754228ff-d1d4-46b9-8dd0-fcf33f99ea73")
                        },
                        new
                        {
                            Id = new Guid("fbf498bc-6a70-4bce-a63d-935c0dcb5a03"),
                            CityImagePath = "",
                            CityName = "Лион",
                            CountryId = new Guid("754228ff-d1d4-46b9-8dd0-fcf33f99ea73")
                        },
                        new
                        {
                            Id = new Guid("d19ea388-93bf-48a0-be68-0a1875dc1b75"),
                            CityImagePath = "",
                            CityName = "Тулуза",
                            CountryId = new Guid("754228ff-d1d4-46b9-8dd0-fcf33f99ea73")
                        },
                        new
                        {
                            Id = new Guid("582cba50-886e-41c8-b662-5df063436c62"),
                            CityImagePath = "",
                            CityName = "Вашингтон",
                            CountryId = new Guid("3a3935d7-1231-491a-8aff-a22827502133")
                        },
                        new
                        {
                            Id = new Guid("9512bae9-e745-404b-9279-3b5fe9df2611"),
                            CityImagePath = "",
                            CityName = "Нью-Йорк",
                            CountryId = new Guid("3a3935d7-1231-491a-8aff-a22827502133")
                        },
                        new
                        {
                            Id = new Guid("c9e1a5d5-5c37-484d-8f19-2a18c26bab99"),
                            CityImagePath = "",
                            CityName = "Лос-Анджелес",
                            CountryId = new Guid("3a3935d7-1231-491a-8aff-a22827502133")
                        },
                        new
                        {
                            Id = new Guid("fa1cc95d-e6e4-47b7-ace6-97e8a145f154"),
                            CityImagePath = "",
                            CityName = "Чикаго",
                            CountryId = new Guid("3a3935d7-1231-491a-8aff-a22827502133")
                        },
                        new
                        {
                            Id = new Guid("cc38ec5a-1982-49b7-86db-f81d79bb0cca"),
                            CityImagePath = "",
                            CityName = "Пхеньян",
                            CountryId = new Guid("17ddbfc8-136e-49b7-ab28-b0dea2e8c31f")
                        },
                        new
                        {
                            Id = new Guid("c0f4daa7-3e1d-4824-9b4a-cbc76a72d95e"),
                            CityImagePath = "",
                            CityName = "Хамхын",
                            CountryId = new Guid("17ddbfc8-136e-49b7-ab28-b0dea2e8c31f")
                        },
                        new
                        {
                            Id = new Guid("08205912-e30f-414a-b71d-3fb9da502229"),
                            CityImagePath = "",
                            CityName = "Чхонджин",
                            CountryId = new Guid("17ddbfc8-136e-49b7-ab28-b0dea2e8c31f")
                        },
                        new
                        {
                            Id = new Guid("9ab98072-bd2b-4453-a552-8dfea72be90e"),
                            CityImagePath = "",
                            CityName = "Нампхо",
                            CountryId = new Guid("17ddbfc8-136e-49b7-ab28-b0dea2e8c31f")
                        },
                        new
                        {
                            Id = new Guid("03bc7a8b-0ccb-466e-92a4-c35a54c93d8e"),
                            CityImagePath = "",
                            CityName = "Тегеран",
                            CountryId = new Guid("70fda919-4e02-4d77-88fe-0bf87ebe2bb3")
                        },
                        new
                        {
                            Id = new Guid("a7046280-c3dc-46a5-bbc4-f9248c689ef4"),
                            CityImagePath = "",
                            CityName = "Мешхед",
                            CountryId = new Guid("70fda919-4e02-4d77-88fe-0bf87ebe2bb3")
                        },
                        new
                        {
                            Id = new Guid("bb834d55-ece6-4b1a-bfae-d1073d590d3d"),
                            CityImagePath = "",
                            CityName = "Исфахан",
                            CountryId = new Guid("70fda919-4e02-4d77-88fe-0bf87ebe2bb3")
                        },
                        new
                        {
                            Id = new Guid("ecaed737-9a95-43cb-a240-d9bcc861ae29"),
                            CityImagePath = "",
                            CityName = "Кередж",
                            CountryId = new Guid("70fda919-4e02-4d77-88fe-0bf87ebe2bb3")
                        },
                        new
                        {
                            Id = new Guid("15b85388-5715-4c46-8672-6247c4482070"),
                            CityImagePath = "",
                            CityName = "Гавана",
                            CountryId = new Guid("82544f8b-1aaa-4520-85ce-c1df06bc765f")
                        },
                        new
                        {
                            Id = new Guid("47072e9d-08ef-4e41-a7f6-db40071d50c2"),
                            CityImagePath = "",
                            CityName = "Санктьяго-де-Куба",
                            CountryId = new Guid("82544f8b-1aaa-4520-85ce-c1df06bc765f")
                        },
                        new
                        {
                            Id = new Guid("f8a8984a-39e6-4d30-a36d-3abfc36a31ad"),
                            CityImagePath = "",
                            CityName = "Камагуэй",
                            CountryId = new Guid("82544f8b-1aaa-4520-85ce-c1df06bc765f")
                        },
                        new
                        {
                            Id = new Guid("7558fa08-1837-4a18-b2cb-058b2a0f3f5d"),
                            CityImagePath = "",
                            CityName = "Ольгин",
                            CountryId = new Guid("82544f8b-1aaa-4520-85ce-c1df06bc765f")
                        },
                        new
                        {
                            Id = new Guid("e8376d92-6890-4a9c-aeb1-2ad11eb01c90"),
                            CityImagePath = "",
                            CityName = "Канберра",
                            CountryId = new Guid("69aead7e-f641-4040-98f9-55b2193e7ea8")
                        },
                        new
                        {
                            Id = new Guid("e81e4e1e-fcfc-4df5-a956-f7729c69e6bc"),
                            CityImagePath = "",
                            CityName = "Сидней",
                            CountryId = new Guid("69aead7e-f641-4040-98f9-55b2193e7ea8")
                        },
                        new
                        {
                            Id = new Guid("27bb7aa0-cef2-4041-a792-54183c8b0e7f"),
                            CityImagePath = "",
                            CityName = "Мельбурн",
                            CountryId = new Guid("69aead7e-f641-4040-98f9-55b2193e7ea8")
                        },
                        new
                        {
                            Id = new Guid("e528a6b1-2572-464f-bd69-5f41cd33f713"),
                            CityImagePath = "",
                            CityName = "Брисбен",
                            CountryId = new Guid("69aead7e-f641-4040-98f9-55b2193e7ea8")
                        },
                        new
                        {
                            Id = new Guid("2dcefe9e-7256-4b91-93fa-5542681f1f67"),
                            CityImagePath = "",
                            CityName = "Кейптаун",
                            CountryId = new Guid("431b090e-ecc6-46f9-a3b8-bd2de50d4b07")
                        },
                        new
                        {
                            Id = new Guid("4d67d90d-8386-45e5-a74a-cadf89f75994"),
                            CityImagePath = "",
                            CityName = "Йоханнесбург",
                            CountryId = new Guid("431b090e-ecc6-46f9-a3b8-bd2de50d4b07")
                        },
                        new
                        {
                            Id = new Guid("1a9ecb7a-6fbd-4a92-8517-9f5e6f9b4e23"),
                            CityImagePath = "",
                            CityName = "Дурбан",
                            CountryId = new Guid("431b090e-ecc6-46f9-a3b8-bd2de50d4b07")
                        },
                        new
                        {
                            Id = new Guid("05fbc9e2-792b-42de-9a2b-5b27e7a38b65"),
                            CityImagePath = "",
                            CityName = "Претория",
                            CountryId = new Guid("431b090e-ecc6-46f9-a3b8-bd2de50d4b07")
                        });
                });

            modelBuilder.Entity("Game.Infrastructure.Seed.CountryPattern", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FlagImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CountryPatterns", "Game");

                    b.HasData(
                        new
                        {
                            Id = new Guid("121ba607-2ca9-4766-8483-405db23ccd1a"),
                            CountryName = "Россия",
                            FlagImagePath = ""
                        },
                        new
                        {
                            Id = new Guid("10f3f392-b035-4031-bd25-289273b99d0c"),
                            CountryName = "Китай",
                            FlagImagePath = ""
                        },
                        new
                        {
                            Id = new Guid("a96b3639-4c39-40b7-a248-b39b35b13b34"),
                            CountryName = "Япония",
                            FlagImagePath = ""
                        },
                        new
                        {
                            Id = new Guid("b00a5af6-6cec-464c-9e62-a75f1d97e247"),
                            CountryName = "Германия",
                            FlagImagePath = ""
                        },
                        new
                        {
                            Id = new Guid("754228ff-d1d4-46b9-8dd0-fcf33f99ea73"),
                            CountryName = "Франция",
                            FlagImagePath = ""
                        },
                        new
                        {
                            Id = new Guid("3a3935d7-1231-491a-8aff-a22827502133"),
                            CountryName = "США",
                            FlagImagePath = ""
                        },
                        new
                        {
                            Id = new Guid("17ddbfc8-136e-49b7-ab28-b0dea2e8c31f"),
                            CountryName = "Северная Корея",
                            FlagImagePath = ""
                        },
                        new
                        {
                            Id = new Guid("70fda919-4e02-4d77-88fe-0bf87ebe2bb3"),
                            CountryName = "Иран",
                            FlagImagePath = ""
                        },
                        new
                        {
                            Id = new Guid("82544f8b-1aaa-4520-85ce-c1df06bc765f"),
                            CountryName = "Куба",
                            FlagImagePath = ""
                        },
                        new
                        {
                            Id = new Guid("69aead7e-f641-4040-98f9-55b2193e7ea8"),
                            CountryName = "Австралия",
                            FlagImagePath = ""
                        },
                        new
                        {
                            Id = new Guid("431b090e-ecc6-46f9-a3b8-bd2de50d4b07"),
                            CountryName = "Южная Африка",
                            FlagImagePath = ""
                        });
                });

            modelBuilder.Entity("Game.Domain.RoomAggregate.Entities.Organizer", b =>
                {
                    b.HasBaseType("Game.Domain.DomainModels.RoomAggregate.Abstractions.RoomMember");

                    b.HasDiscriminator().HasValue("Organizer");
                });

            modelBuilder.Entity("Game.Domain.RoomAggregate.Entities.Player", b =>
                {
                    b.HasBaseType("Game.Domain.DomainModels.RoomAggregate.Abstractions.RoomMember");

                    b.HasDiscriminator().HasValue("Player");
                });

            modelBuilder.Entity("Game.Domain.CountryAggregate.Entities.City", b =>
                {
                    b.HasOne("Game.Domain.CountryAggregate.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Game.Domain.CountryAggregate.Entities.Country", b =>
                {
                    b.HasOne("Game.Domain.GameAggregate.Entities.Game", "Game")
                        .WithMany("Countries")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.RoomAggregate.Abstractions.RoomMember", b =>
                {
                    b.HasOne("Game.Domain.CountryAggregate.Entities.Country", "Country")
                        .WithMany("Players")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Game.Domain.UserAggregate.Entities.GameUser", "GameUser")
                        .WithMany("CreatedMembers")
                        .HasForeignKey("GameUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Game.Domain.RoomAggregate.Entities.Room", "Room")
                        .WithMany("RoomMembers")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("GameUser");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Game.Domain.GameAggregate.Entities.Game", b =>
                {
                    b.HasOne("Game.Domain.RoomAggregate.Entities.Room", "Room")
                        .WithOne("DomainGame")
                        .HasForeignKey("Game.Domain.GameAggregate.Entities.Game", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Game.Domain.RoomAggregate.Entities.Room", b =>
                {
                    b.HasOne("Game.Domain.UserAggregate.Entities.GameUser", "Creator")
                        .WithMany("Rooms")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Game.Infrastructure.Seed.CityPattern", b =>
                {
                    b.HasOne("Game.Infrastructure.Seed.CountryPattern", "CountryPattern")
                        .WithMany("CityPatterns")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CountryPattern");
                });

            modelBuilder.Entity("Game.Domain.CountryAggregate.Entities.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("Game.Domain.GameAggregate.Entities.Game", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Game.Domain.RoomAggregate.Entities.Room", b =>
                {
                    b.Navigation("DomainGame")
                        .IsRequired();

                    b.Navigation("RoomMembers");
                });

            modelBuilder.Entity("Game.Domain.UserAggregate.Entities.GameUser", b =>
                {
                    b.Navigation("CreatedMembers");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Game.Infrastructure.Seed.CountryPattern", b =>
                {
                    b.Navigation("CityPatterns");
                });
#pragma warning restore 612, 618
        }
    }
}
