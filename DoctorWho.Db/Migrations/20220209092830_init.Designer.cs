﻿// <auto-generated />
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20220209092830_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoctorWho.Db.DataModels.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DoctorWho.Db.DataModels.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");
                });

            modelBuilder.Entity("DoctorWho.Db.DataModels.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DoctorNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstEpisodeDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastEpisodeDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("DoctorWho.Db.DataModels.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");
                });

            modelBuilder.Entity("DoctorWho.Db.DataModels.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.DataModels.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeId", "CompanionId");

                    b.HasIndex("CompanionId");

                    b.ToTable("EpisodeCompanion");
                });

            modelBuilder.Entity("DoctorWho.Db.DataModels.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeId", "EnemyId");

                    b.HasIndex("EnemyId");

                    b.ToTable("EpisodeEnemy");
                });

            modelBuilder.Entity("DoctorWho.Db.DataModels.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.DataModels.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.DataModels.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.Db.DataModels.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.DataModels.Companion", null)
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.DataModels.Episode", null)
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.Db.DataModels.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.DataModels.Enemy", null)
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.DataModels.Episode", null)
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}