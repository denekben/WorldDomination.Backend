﻿// <auto-generated />
using System;
using AppUser.Infrastructure.DomainUser.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AppUser.Infrastructure.DomainUser.Migrations
{
    [DbContext(typeof(UserReadDbContext))]
    [Migration("20241002162703_Init_UserRead")]
    partial class Init_UserRead
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("AppUser")
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AppUser.Infrastructure.DomainUser.ReadModels.AchievmentReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Achievments", "AppUser");
                });

            modelBuilder.Entity("AppUser.Infrastructure.DomainUser.ReadModels.ActivityStatusReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("GameRole")
                        .HasColumnType("text");

                    b.Property<string>("IsInGameStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RoundNumber")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("ActivityStatuses", "AppUser");
                });

            modelBuilder.Entity("AppUser.Infrastructure.DomainUser.ReadModels.UserAchievmentReadModel", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AchievmentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("AchievedTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("UserId", "AchievmentId");

                    b.HasIndex("AchievmentId");

                    b.ToTable("UserAchievments", "AppUser");
                });

            modelBuilder.Entity("AppUser.Infrastructure.DomainUser.ReadModels.UserReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProfileImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users", "AppUser");
                });

            modelBuilder.Entity("AppUser.Infrastructure.DomainUser.ReadModels.ActivityStatusReadModel", b =>
                {
                    b.HasOne("AppUser.Infrastructure.DomainUser.ReadModels.UserReadModel", "UserReadModel")
                        .WithOne("ActivityStatusReadModel")
                        .HasForeignKey("AppUser.Infrastructure.DomainUser.ReadModels.ActivityStatusReadModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserReadModel");
                });

            modelBuilder.Entity("AppUser.Infrastructure.DomainUser.ReadModels.UserAchievmentReadModel", b =>
                {
                    b.HasOne("AppUser.Infrastructure.DomainUser.ReadModels.AchievmentReadModel", "AchievmentReadModel")
                        .WithMany("UserAchievments")
                        .HasForeignKey("AchievmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppUser.Infrastructure.DomainUser.ReadModels.UserReadModel", "UserReadModel")
                        .WithMany("UserAchievments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AchievmentReadModel");

                    b.Navigation("UserReadModel");
                });

            modelBuilder.Entity("AppUser.Infrastructure.DomainUser.ReadModels.AchievmentReadModel", b =>
                {
                    b.Navigation("UserAchievments");
                });

            modelBuilder.Entity("AppUser.Infrastructure.DomainUser.ReadModels.UserReadModel", b =>
                {
                    b.Navigation("ActivityStatusReadModel")
                        .IsRequired();

                    b.Navigation("UserAchievments");
                });
#pragma warning restore 612, 618
        }
    }
}
