﻿// <auto-generated />
using System;
using Game.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Game.Infrastructure.Migrations
{
    [DbContext(typeof(GameWriteDbContext))]
    [Migration("20241031151442_Init_GameWrite")]
    partial class Init_GameWrite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Game")
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Game.Domain.DomainModels.Games.Entities.City", b =>
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

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities", "Game");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Games.Entities.Country", b =>
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

                    b.Property<Guid?>("GameId")
                        .HasColumnType("uuid");

                    b.Property<bool>("HaveNuclearTechnology")
                        .HasColumnType("boolean");

                    b.Property<int>("LivingLevel")
                        .HasColumnType("integer");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NuclearTechnology")
                        .HasColumnType("integer");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uuid");

                    b.Property<int>("SanctionCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("RoomId");

                    b.ToTable("Countries", "Game");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Games.Entities.Game", b =>
                {
                    b.Property<Guid>("RoomId")
                        .HasColumnType("uuid");

                    b.Property<int>("CurrentRound")
                        .HasColumnType("integer");

                    b.Property<int>("EcologyLevel")
                        .HasColumnType("integer");

                    b.Property<string>("GameType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("HasTeams")
                        .HasColumnType("boolean");

                    b.HasKey("RoomId");

                    b.ToTable("Games", "Game");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Rooms.Entities.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2024, 10, 31, 15, 14, 42, 613, DateTimeKind.Utc).AddTicks(1499));

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("GameType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("HasTeams")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("boolean");

                    b.Property<string>("RoomCode")
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

            modelBuilder.Entity("Game.Domain.DomainModels.Rooms.Entities.RoomMember", b =>
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

            modelBuilder.Entity("Game.Domain.DomainModels.Users.Entities.GameUser", b =>
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

                    b.Property<bool>("IsCapital")
                        .HasColumnType("boolean");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("CityPatterns", "Game");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2bb8d811-14ee-4e0a-99ef-591983db4083"),
                            CityImagePath = "",
                            CityName = "Москва",
                            CountryId = new Guid("20747f9a-e5cc-4916-96f6-c0bd96c5a157"),
                            IsCapital = true,
                            NormalizedName = "MOSCOW"
                        },
                        new
                        {
                            Id = new Guid("99660a4e-0dfc-4c92-8fce-66c709ef647d"),
                            CityImagePath = "",
                            CityName = "Санкт-Петербург",
                            CountryId = new Guid("20747f9a-e5cc-4916-96f6-c0bd96c5a157"),
                            IsCapital = false,
                            NormalizedName = "SAINT PETERSBURG"
                        },
                        new
                        {
                            Id = new Guid("f30f26fb-1649-4526-9998-cc86d53fe82f"),
                            CityImagePath = "",
                            CityName = "Екатеринбург",
                            CountryId = new Guid("20747f9a-e5cc-4916-96f6-c0bd96c5a157"),
                            IsCapital = false,
                            NormalizedName = "YEKATERINBURG"
                        },
                        new
                        {
                            Id = new Guid("5043fbb5-af03-4b5e-9f12-8a27ec73b4f9"),
                            CityImagePath = "",
                            CityName = "Новосибирск",
                            CountryId = new Guid("20747f9a-e5cc-4916-96f6-c0bd96c5a157"),
                            IsCapital = false,
                            NormalizedName = "NOVOSIBIRSK"
                        },
                        new
                        {
                            Id = new Guid("64abe1d3-5b95-4c95-8d41-c45ba9563092"),
                            CityImagePath = "",
                            CityName = "Пекин",
                            CountryId = new Guid("5be6d899-da5f-4aa8-b78c-dd13246fe97c"),
                            IsCapital = true,
                            NormalizedName = "BEIJING"
                        },
                        new
                        {
                            Id = new Guid("bbbf67a4-cbb7-4bd5-be4f-1c758695dd6d"),
                            CityImagePath = "",
                            CityName = "Шанхай",
                            CountryId = new Guid("5be6d899-da5f-4aa8-b78c-dd13246fe97c"),
                            IsCapital = false,
                            NormalizedName = "SHANGHAI"
                        },
                        new
                        {
                            Id = new Guid("f78a88a8-08fc-4441-b9fa-6af97c4891d9"),
                            CityImagePath = "",
                            CityName = "Чунцин",
                            CountryId = new Guid("5be6d899-da5f-4aa8-b78c-dd13246fe97c"),
                            IsCapital = false,
                            NormalizedName = "CHONGQING"
                        },
                        new
                        {
                            Id = new Guid("92b46bf5-e55a-419b-9a68-42b431d30601"),
                            CityImagePath = "",
                            CityName = "Тяньцзинь",
                            CountryId = new Guid("5be6d899-da5f-4aa8-b78c-dd13246fe97c"),
                            IsCapital = false,
                            NormalizedName = "TIANJIN"
                        },
                        new
                        {
                            Id = new Guid("d8410095-e2f6-4fbb-94b9-3423164baaed"),
                            CityImagePath = "",
                            CityName = "Токио",
                            CountryId = new Guid("a6b41aea-b82f-4ee0-86d1-ce3e0c8396a4"),
                            IsCapital = true,
                            NormalizedName = "TOKYO"
                        },
                        new
                        {
                            Id = new Guid("96570f4a-6d29-4eaf-a70b-ec2d4bea01fe"),
                            CityImagePath = "",
                            CityName = "Йокогама",
                            CountryId = new Guid("a6b41aea-b82f-4ee0-86d1-ce3e0c8396a4"),
                            IsCapital = false,
                            NormalizedName = "YOKOHAMA"
                        },
                        new
                        {
                            Id = new Guid("2e5e2a2b-ae74-4cab-993b-254210f8ca89"),
                            CityImagePath = "",
                            CityName = "Осака",
                            CountryId = new Guid("a6b41aea-b82f-4ee0-86d1-ce3e0c8396a4"),
                            IsCapital = false,
                            NormalizedName = "OSAKA"
                        },
                        new
                        {
                            Id = new Guid("f8fafec3-abb6-4e62-8506-659887dcda2f"),
                            CityImagePath = "",
                            CityName = "Нагоя",
                            CountryId = new Guid("a6b41aea-b82f-4ee0-86d1-ce3e0c8396a4"),
                            IsCapital = false,
                            NormalizedName = "NAGOYA"
                        },
                        new
                        {
                            Id = new Guid("72fafb3d-aaa9-4ae1-a000-0b67649db2a1"),
                            CityImagePath = "",
                            CityName = "Берлин",
                            CountryId = new Guid("2f97369a-5c50-4926-8684-092f66401bdb"),
                            IsCapital = false,
                            NormalizedName = "BERLIN"
                        },
                        new
                        {
                            Id = new Guid("0d45f691-4c1f-4565-aa5a-aaaaa790d7c6"),
                            CityImagePath = "",
                            CityName = "Гамбург",
                            CountryId = new Guid("2f97369a-5c50-4926-8684-092f66401bdb"),
                            IsCapital = false,
                            NormalizedName = "HAMBURG"
                        },
                        new
                        {
                            Id = new Guid("8ec8a013-aa6f-4814-a499-0b57a71b9ca3"),
                            CityImagePath = "",
                            CityName = "Мюнхен",
                            CountryId = new Guid("2f97369a-5c50-4926-8684-092f66401bdb"),
                            IsCapital = false,
                            NormalizedName = "MUNICH"
                        },
                        new
                        {
                            Id = new Guid("4f098407-b981-4d82-843a-b04f0db5965e"),
                            CityImagePath = "",
                            CityName = "Кёльн",
                            CountryId = new Guid("2f97369a-5c50-4926-8684-092f66401bdb"),
                            IsCapital = false,
                            NormalizedName = "COLOGNE"
                        },
                        new
                        {
                            Id = new Guid("e7174ba2-709d-4ed2-bf7b-b4542dff5a92"),
                            CityImagePath = "",
                            CityName = "Париж",
                            CountryId = new Guid("e0e24634-9482-4557-b5a7-eb87661dcee2"),
                            IsCapital = true,
                            NormalizedName = "PARIS"
                        },
                        new
                        {
                            Id = new Guid("f53d398c-1452-4989-9905-3387c5f4fc4f"),
                            CityImagePath = "",
                            CityName = "Марсель",
                            CountryId = new Guid("e0e24634-9482-4557-b5a7-eb87661dcee2"),
                            IsCapital = false,
                            NormalizedName = "MARSEILLE"
                        },
                        new
                        {
                            Id = new Guid("5d66e62f-119c-4e1f-86cd-ad03bcb80e12"),
                            CityImagePath = "",
                            CityName = "Лион",
                            CountryId = new Guid("e0e24634-9482-4557-b5a7-eb87661dcee2"),
                            IsCapital = false,
                            NormalizedName = "LYON"
                        },
                        new
                        {
                            Id = new Guid("ebff9251-caae-4860-b86c-67ff04245a2e"),
                            CityImagePath = "",
                            CityName = "Тулуза",
                            CountryId = new Guid("e0e24634-9482-4557-b5a7-eb87661dcee2"),
                            IsCapital = false,
                            NormalizedName = "TOULOUSE"
                        },
                        new
                        {
                            Id = new Guid("3ea67e8f-6ee0-4982-be64-68642437e87f"),
                            CityImagePath = "",
                            CityName = "Вашингтон",
                            CountryId = new Guid("8fee0964-ff1d-4581-be09-f7d01a15ccf8"),
                            IsCapital = true,
                            NormalizedName = "WASHINGTON D.C."
                        },
                        new
                        {
                            Id = new Guid("c394b101-25e8-4be2-95cc-c0038b70eba8"),
                            CityImagePath = "",
                            CityName = "Нью-Йорк",
                            CountryId = new Guid("8fee0964-ff1d-4581-be09-f7d01a15ccf8"),
                            IsCapital = false,
                            NormalizedName = "NEW YORK CITY"
                        },
                        new
                        {
                            Id = new Guid("b68466b2-4d54-4b36-aea6-f351f9e59612"),
                            CityImagePath = "",
                            CityName = "Лос-Анджелес",
                            CountryId = new Guid("8fee0964-ff1d-4581-be09-f7d01a15ccf8"),
                            IsCapital = false,
                            NormalizedName = "LOS ANGELES"
                        },
                        new
                        {
                            Id = new Guid("bc5db3f9-434b-49e5-8ea5-e82c945ad10a"),
                            CityImagePath = "",
                            CityName = "Чикаго",
                            CountryId = new Guid("8fee0964-ff1d-4581-be09-f7d01a15ccf8"),
                            IsCapital = false,
                            NormalizedName = "CHICAGO"
                        },
                        new
                        {
                            Id = new Guid("097371d6-d5f3-4c59-a3f3-35817f8c7e15"),
                            CityImagePath = "",
                            CityName = "Пхеньян",
                            CountryId = new Guid("a959d539-be49-4216-9234-26ebd46f48e9"),
                            IsCapital = true,
                            NormalizedName = "PYONGYANG"
                        },
                        new
                        {
                            Id = new Guid("7af76635-3df1-4f3d-af5b-6cfbccd2037f"),
                            CityImagePath = "",
                            CityName = "Хамхын",
                            CountryId = new Guid("a959d539-be49-4216-9234-26ebd46f48e9"),
                            IsCapital = false,
                            NormalizedName = "HAMHUNG"
                        },
                        new
                        {
                            Id = new Guid("683fbe15-edc9-43ee-81bf-49d807fc1644"),
                            CityImagePath = "",
                            CityName = "Чхонджин",
                            CountryId = new Guid("a959d539-be49-4216-9234-26ebd46f48e9"),
                            IsCapital = false,
                            NormalizedName = "CHONJIN"
                        },
                        new
                        {
                            Id = new Guid("ff205331-9d0f-4951-8675-a419a4d849ce"),
                            CityImagePath = "",
                            CityName = "Нампхо",
                            CountryId = new Guid("a959d539-be49-4216-9234-26ebd46f48e9"),
                            IsCapital = false,
                            NormalizedName = "NAMPO"
                        },
                        new
                        {
                            Id = new Guid("9f943c40-6d97-4a7d-839d-cfaaec2d5fe1"),
                            CityImagePath = "",
                            CityName = "Тегеран",
                            CountryId = new Guid("279c40f4-fd73-4086-8d54-3b21eb169f57"),
                            IsCapital = true,
                            NormalizedName = "TEHRAN"
                        },
                        new
                        {
                            Id = new Guid("686ab953-0a12-40e6-9043-1610a540bccc"),
                            CityImagePath = "",
                            CityName = "Мешхед",
                            CountryId = new Guid("279c40f4-fd73-4086-8d54-3b21eb169f57"),
                            IsCapital = false,
                            NormalizedName = "MASHHAD"
                        },
                        new
                        {
                            Id = new Guid("8fecd871-7c8e-4a99-a599-9255d81665c7"),
                            CityImagePath = "",
                            CityName = "Исфахан",
                            CountryId = new Guid("279c40f4-fd73-4086-8d54-3b21eb169f57"),
                            IsCapital = false,
                            NormalizedName = "ISFAHAN"
                        },
                        new
                        {
                            Id = new Guid("1c66a20e-fbaa-46a7-a27b-aa280d2e318d"),
                            CityImagePath = "",
                            CityName = "Кередж",
                            CountryId = new Guid("279c40f4-fd73-4086-8d54-3b21eb169f57"),
                            IsCapital = false,
                            NormalizedName = "KARAJ"
                        },
                        new
                        {
                            Id = new Guid("130aeab0-d375-4c33-aa57-eedb2780a667"),
                            CityImagePath = "",
                            CityName = "Гавана",
                            CountryId = new Guid("ed8be004-d9b6-4ec5-9861-6e7359ad4e30"),
                            IsCapital = true,
                            NormalizedName = "HAVANA"
                        },
                        new
                        {
                            Id = new Guid("ab4b8d4c-3d36-43a5-80a9-65c421f20729"),
                            CityImagePath = "",
                            CityName = "Санктьяго-де-Куба",
                            CountryId = new Guid("ed8be004-d9b6-4ec5-9861-6e7359ad4e30"),
                            IsCapital = false,
                            NormalizedName = "SANTIAGO DE CUBA"
                        },
                        new
                        {
                            Id = new Guid("a8f68bf2-7504-4309-bb79-0dd71709d9e1"),
                            CityImagePath = "",
                            CityName = "Камагуэй",
                            CountryId = new Guid("ed8be004-d9b6-4ec5-9861-6e7359ad4e30"),
                            IsCapital = false,
                            NormalizedName = "CAMAGUEY"
                        },
                        new
                        {
                            Id = new Guid("2331501e-5c3d-4974-96a3-a9c520095d86"),
                            CityImagePath = "",
                            CityName = "Ольгин",
                            CountryId = new Guid("ed8be004-d9b6-4ec5-9861-6e7359ad4e30"),
                            IsCapital = false,
                            NormalizedName = "OLGUIN"
                        },
                        new
                        {
                            Id = new Guid("69953de8-04ab-46b8-bb58-79f994855c1f"),
                            CityImagePath = "",
                            CityName = "Канберра",
                            CountryId = new Guid("026bf104-7588-4be7-b0cf-712b785504a5"),
                            IsCapital = true,
                            NormalizedName = "CANBERRA"
                        },
                        new
                        {
                            Id = new Guid("fad816e5-cd56-4aae-b07b-22f99f9086c5"),
                            CityImagePath = "",
                            CityName = "Сидней",
                            CountryId = new Guid("026bf104-7588-4be7-b0cf-712b785504a5"),
                            IsCapital = false,
                            NormalizedName = "SYDNEY"
                        },
                        new
                        {
                            Id = new Guid("7e1bbd3d-3f52-4009-a329-8a7e96dd53d3"),
                            CityImagePath = "",
                            CityName = "Мельбурн",
                            CountryId = new Guid("026bf104-7588-4be7-b0cf-712b785504a5"),
                            IsCapital = false,
                            NormalizedName = "MELBOURNE"
                        },
                        new
                        {
                            Id = new Guid("7e05ca47-273f-4698-a23a-8e397bb8f905"),
                            CityImagePath = "",
                            CityName = "Брисбен",
                            CountryId = new Guid("026bf104-7588-4be7-b0cf-712b785504a5"),
                            IsCapital = false,
                            NormalizedName = "BRISBANE"
                        },
                        new
                        {
                            Id = new Guid("7c47cf7c-7bf4-4a16-a051-c5a3ec26d1c4"),
                            CityImagePath = "",
                            CityName = "Кейптаун",
                            CountryId = new Guid("45e42d47-dd50-421b-8d7f-4510f68fefb1"),
                            IsCapital = true,
                            NormalizedName = "CAPE TOWN"
                        },
                        new
                        {
                            Id = new Guid("4388c4cc-7eb3-4266-8598-a698720590c4"),
                            CityImagePath = "",
                            CityName = "Йоханнесбург",
                            CountryId = new Guid("45e42d47-dd50-421b-8d7f-4510f68fefb1"),
                            IsCapital = false,
                            NormalizedName = "JOHANNESBURG"
                        },
                        new
                        {
                            Id = new Guid("f1e59a7d-65b4-4e09-82c4-3eeffeef2d24"),
                            CityImagePath = "",
                            CityName = "Дурбан",
                            CountryId = new Guid("45e42d47-dd50-421b-8d7f-4510f68fefb1"),
                            IsCapital = false,
                            NormalizedName = "DURBAN"
                        },
                        new
                        {
                            Id = new Guid("bc5d586f-a31a-477e-8e70-77ece368e497"),
                            CityImagePath = "",
                            CityName = "Претория",
                            CountryId = new Guid("45e42d47-dd50-421b-8d7f-4510f68fefb1"),
                            IsCapital = false,
                            NormalizedName = "PRETORIA"
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

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CountryPatterns", "Game");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20747f9a-e5cc-4916-96f6-c0bd96c5a157"),
                            CountryName = "Россия",
                            FlagImagePath = "",
                            NormalizedName = "RUSSIA"
                        },
                        new
                        {
                            Id = new Guid("5be6d899-da5f-4aa8-b78c-dd13246fe97c"),
                            CountryName = "Китай",
                            FlagImagePath = "",
                            NormalizedName = "CHINA"
                        },
                        new
                        {
                            Id = new Guid("a6b41aea-b82f-4ee0-86d1-ce3e0c8396a4"),
                            CountryName = "Япония",
                            FlagImagePath = "",
                            NormalizedName = "JAPAN"
                        },
                        new
                        {
                            Id = new Guid("2f97369a-5c50-4926-8684-092f66401bdb"),
                            CountryName = "Германия",
                            FlagImagePath = "",
                            NormalizedName = "GERMANY"
                        },
                        new
                        {
                            Id = new Guid("e0e24634-9482-4557-b5a7-eb87661dcee2"),
                            CountryName = "Франция",
                            FlagImagePath = "",
                            NormalizedName = "FRANCE"
                        },
                        new
                        {
                            Id = new Guid("8fee0964-ff1d-4581-be09-f7d01a15ccf8"),
                            CountryName = "США",
                            FlagImagePath = "",
                            NormalizedName = "UNITED STATES"
                        },
                        new
                        {
                            Id = new Guid("a959d539-be49-4216-9234-26ebd46f48e9"),
                            CountryName = "Северная Корея",
                            FlagImagePath = "",
                            NormalizedName = "NORTH KOREA"
                        },
                        new
                        {
                            Id = new Guid("279c40f4-fd73-4086-8d54-3b21eb169f57"),
                            CountryName = "Иран",
                            FlagImagePath = "",
                            NormalizedName = "IRAN"
                        },
                        new
                        {
                            Id = new Guid("ed8be004-d9b6-4ec5-9861-6e7359ad4e30"),
                            CountryName = "Куба",
                            FlagImagePath = "",
                            NormalizedName = "CUBA"
                        },
                        new
                        {
                            Id = new Guid("026bf104-7588-4be7-b0cf-712b785504a5"),
                            CountryName = "Австралия",
                            FlagImagePath = "",
                            NormalizedName = "AUSTRALIA"
                        },
                        new
                        {
                            Id = new Guid("45e42d47-dd50-421b-8d7f-4510f68fefb1"),
                            CountryName = "Южная Африка",
                            FlagImagePath = "",
                            NormalizedName = "SOUTH AFRICA"
                        });
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Rooms.Entities.Organizer", b =>
                {
                    b.HasBaseType("Game.Domain.DomainModels.Rooms.Entities.RoomMember");

                    b.HasDiscriminator().HasValue("Organizer");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Rooms.Entities.Player", b =>
                {
                    b.HasBaseType("Game.Domain.DomainModels.Rooms.Entities.RoomMember");

                    b.HasDiscriminator().HasValue("Player");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Games.Entities.City", b =>
                {
                    b.HasOne("Game.Domain.DomainModels.Games.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Games.Entities.Country", b =>
                {
                    b.HasOne("Game.Domain.DomainModels.Games.Entities.Game", "Game")
                        .WithMany("Countries")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Game.Domain.DomainModels.Rooms.Entities.Room", "Room")
                        .WithMany("Countries")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Games.Entities.Game", b =>
                {
                    b.HasOne("Game.Domain.DomainModels.Rooms.Entities.Room", "Room")
                        .WithOne("DomainGame")
                        .HasForeignKey("Game.Domain.DomainModels.Games.Entities.Game", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Rooms.Entities.Room", b =>
                {
                    b.HasOne("Game.Domain.DomainModels.Users.Entities.GameUser", "Creator")
                        .WithMany("Rooms")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Rooms.Entities.RoomMember", b =>
                {
                    b.HasOne("Game.Domain.DomainModels.Games.Entities.Country", "Country")
                        .WithMany("Players")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Game.Domain.DomainModels.Users.Entities.GameUser", "GameUser")
                        .WithMany("CreatedMembers")
                        .HasForeignKey("GameUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Game.Domain.DomainModels.Rooms.Entities.Room", "Room")
                        .WithMany("RoomMembers")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("GameUser");

                    b.Navigation("Room");
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

            modelBuilder.Entity("Game.Domain.DomainModels.Games.Entities.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Games.Entities.Game", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Rooms.Entities.Room", b =>
                {
                    b.Navigation("Countries");

                    b.Navigation("DomainGame")
                        .IsRequired();

                    b.Navigation("RoomMembers");
                });

            modelBuilder.Entity("Game.Domain.DomainModels.Users.Entities.GameUser", b =>
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
