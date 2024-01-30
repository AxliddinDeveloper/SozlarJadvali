﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SozlarJadvali.Brokers.Storages;

#nullable disable

namespace SozlarJadvali.Migrations
{
    [DbContext(typeof(StorageBroker))]
    [Migration("20240127141645_CreateAllTables")]
    partial class CreateAllTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("SozlarJadvali.Models.Admins.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("SozlarJadvali.Models.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SozlarJadvali.Models.Words.Word", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ManoTuri")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OzbekchaTegi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Shakli")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SofTurkumi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SofvazifaDosh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Turkumi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UslubiyXoslanishi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("XalqaroTegi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("YordamchiSoz")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("YordamchiSozVaOlinganManba")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Word");
                });
#pragma warning restore 612, 618
        }
    }
}
