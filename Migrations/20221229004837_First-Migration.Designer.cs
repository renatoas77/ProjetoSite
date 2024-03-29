﻿// <auto-generated />
using FighteR_PG.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FighteR_PG.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221229004837_First-Migration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FighteR_PG.Models.Archetype", b =>
                {
                    b.Property<int>("ArchetypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArchetypeId"), 1L, 1);

                    b.HasKey("ArchetypeId");

                    b.ToTable("Archetypes");
                });

            modelBuilder.Entity("FighteR_PG.Models.Boss", b =>
                {
                    b.Property<int>("BossId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BossId"), 1L, 1);

                    b.Property<string>("GerneralText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SexId")
                        .HasColumnType("int");

                    b.HasKey("BossId");

                    b.HasIndex("SexId");

                    b.ToTable("Bosses");
                });

            modelBuilder.Entity("FighteR_PG.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("ArchetypeId")
                        .HasColumnType("int");

                    b.Property<string>("Background")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conclusao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Curiosity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dislikes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Food")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fury")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Hit01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hit02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hobbie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ideias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JumpCombo01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JumpCombo02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JumpComboImage01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JumpComboImage02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Likes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunningCombo01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunningCombo02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunningComboImage01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunningComboImage02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunningJumpCombo01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunningJumpCombo02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunningJumpComboImage01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunningJumpComboImage02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SexId")
                        .HasColumnType("int");

                    b.Property<string>("SkilDesc01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc03")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc04")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc05")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc06")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc07")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc08")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc09")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilDesc12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage03")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage04")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage05")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage06")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage07")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage08")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage09")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilImage12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName03")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName04")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName05")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName06")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName07")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName08")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName09")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilName12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Special01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Special02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialDesc01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialDesc02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialImage01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialImage02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StandCombo01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StandCombo02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StandComboImage01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StandComboImage02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WalkingCombo01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WalkingCombo02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WalkingComboImage01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WalkingComboImage02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.HasIndex("ArchetypeId");

                    b.HasIndex("SexId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("FighteR_PG.Models.Sex", b =>
                {
                    b.Property<int>("SexId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SexId"), 1L, 1);

                    b.Property<string>("SexCharacter")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("SexId");

                    b.ToTable("Sexes");
                });

            modelBuilder.Entity("FighteR_PG.Models.Boss", b =>
                {
                    b.HasOne("FighteR_PG.Models.Sex", "Sex")
                        .WithMany("Bosses")
                        .HasForeignKey("SexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sex");
                });

            modelBuilder.Entity("FighteR_PG.Models.Character", b =>
                {
                    b.HasOne("FighteR_PG.Models.Archetype", "Archetype")
                        .WithMany("Characters")
                        .HasForeignKey("ArchetypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FighteR_PG.Models.Sex", "Sex")
                        .WithMany("Characters")
                        .HasForeignKey("SexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Archetype");

                    b.Navigation("Sex");
                });

            modelBuilder.Entity("FighteR_PG.Models.Archetype", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("FighteR_PG.Models.Sex", b =>
                {
                    b.Navigation("Bosses");

                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
