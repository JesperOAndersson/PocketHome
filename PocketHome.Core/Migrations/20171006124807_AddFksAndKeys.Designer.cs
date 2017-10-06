﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PocketHome.Core.Data;
using PocketHome.Core.Models;
using System;

namespace PocketHome.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171006124807_AddFksAndKeys")]
    partial class AddFksAndKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PocketHome.Core.Models.ConditionElement", b =>
                {
                    b.Property<int>("ConditionElementId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ConditionElement");

                    b.Property<int>("DeviceId");

                    b.Property<int>("EventId");

                    b.Property<string>("Light");

                    b.Property<int>("Order");

                    b.Property<string>("Temp");

                    b.Property<string>("Time");

                    b.Property<int>("Type");

                    b.HasKey("ConditionElementId");

                    b.HasIndex("ConditionElement");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("PocketHome.Core.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AltId");

                    b.Property<string>("BatteryLevel");

                    b.Property<int?>("Category");

                    b.Property<string>("Comment");

                    b.Property<int?>("Device");

                    b.Property<string>("KWH");

                    b.Property<string>("Light");

                    b.Property<string>("Name");

                    b.Property<int?>("Parent");

                    b.Property<int?>("Room");

                    b.Property<int?>("State");

                    b.Property<int?>("Status");

                    b.Property<int?>("SubCategory");

                    b.Property<string>("Temperature");

                    b.Property<string>("Watts");

                    b.HasKey("Id");

                    b.HasIndex("Device");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("PocketHome.Core.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("PocketHome.Core.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("Room");

                    b.Property<int?>("Section");

                    b.HasKey("Id");

                    b.HasIndex("Room");

                    b.HasIndex("Section");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("PocketHome.Core.Models.Scene", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Active");

                    b.Property<string>("Name");

                    b.Property<int?>("Room");

                    b.Property<int?>("Scene");

                    b.HasKey("Id");

                    b.HasIndex("Scene");

                    b.ToTable("Scenes");
                });

            modelBuilder.Entity("PocketHome.Core.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("PocketHome.Core.Models.Trigger", b =>
                {
                    b.Property<int>("TriggerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeviceId");

                    b.Property<int>("DeviceType");

                    b.Property<int?>("Trigger");

                    b.HasKey("TriggerId");

                    b.HasIndex("Trigger");

                    b.ToTable("Triggers");
                });

            modelBuilder.Entity("PocketHome.Core.Models.VeraAction", b =>
                {
                    b.Property<int>("VeraActionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<string>("DeviceId");

                    b.Property<int>("DeviceType");

                    b.Property<int?>("VeraAction");

                    b.HasKey("VeraActionId");

                    b.HasIndex("VeraAction");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("PocketHome.Core.Models.ConditionElement", b =>
                {
                    b.HasOne("PocketHome.Core.Models.Event")
                        .WithMany("Conditions")
                        .HasForeignKey("ConditionElement");
                });

            modelBuilder.Entity("PocketHome.Core.Models.Device", b =>
                {
                    b.HasOne("PocketHome.Core.Models.Room")
                        .WithMany("Devices")
                        .HasForeignKey("Device");
                });

            modelBuilder.Entity("PocketHome.Core.Models.Room", b =>
                {
                    b.HasOne("PocketHome.Core.Models.Section")
                        .WithMany("Rooms")
                        .HasForeignKey("Room");

                    b.HasOne("PocketHome.Core.Models.Section", "Section1")
                        .WithMany()
                        .HasForeignKey("Section");
                });

            modelBuilder.Entity("PocketHome.Core.Models.Scene", b =>
                {
                    b.HasOne("PocketHome.Core.Models.Room")
                        .WithMany("Scenes")
                        .HasForeignKey("Scene");
                });

            modelBuilder.Entity("PocketHome.Core.Models.Trigger", b =>
                {
                    b.HasOne("PocketHome.Core.Models.Event")
                        .WithMany("Triggers")
                        .HasForeignKey("Trigger");
                });

            modelBuilder.Entity("PocketHome.Core.Models.VeraAction", b =>
                {
                    b.HasOne("PocketHome.Core.Models.Event")
                        .WithMany("Actions")
                        .HasForeignKey("VeraAction");
                });
#pragma warning restore 612, 618
        }
    }
}
