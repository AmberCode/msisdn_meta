﻿// <auto-generated />
using System;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(MsisdnContext))]
    [Migration("20181218185211_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Msisdn", b =>
                {
                    b.Property<int>("MsisdnId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Number");

                    b.HasKey("MsisdnId");

                    b.HasIndex("Number")
                        .IsUnique();

                    b.ToTable("Msisdns");

                    b.HasData(
                        new
                        {
                            MsisdnId = -1,
                            Number = 37062300001L
                        },
                        new
                        {
                            MsisdnId = -2,
                            Number = 37062300002L
                        },
                        new
                        {
                            MsisdnId = -3,
                            Number = 37062300003L
                        },
                        new
                        {
                            MsisdnId = -4,
                            Number = 37062300004L
                        },
                        new
                        {
                            MsisdnId = -5,
                            Number = 37062300005L
                        },
                        new
                        {
                            MsisdnId = -6,
                            Number = 37062300006L
                        },
                        new
                        {
                            MsisdnId = -7,
                            Number = 37062300007L
                        },
                        new
                        {
                            MsisdnId = -8,
                            Number = 37062300008L
                        },
                        new
                        {
                            MsisdnId = -9,
                            Number = 37062300009L
                        },
                        new
                        {
                            MsisdnId = -10,
                            Number = 37062300010L
                        });
                });

            modelBuilder.Entity("DAL.Entities.Transactions", b =>
                {
                    b.Property<int>("SmsTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Duration");

                    b.Property<int>("MsisdnId");

                    b.Property<int>("TypeId");

                    b.HasKey("SmsTransactionId");

                    b.HasIndex("MsisdnId");

                    b.HasIndex("TypeId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            SmsTransactionId = -1,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 607, DateTimeKind.Local).AddTicks(1860),
                            Duration = 0,
                            MsisdnId = -1,
                            TypeId = 1
                        },
                        new
                        {
                            SmsTransactionId = -2,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8487),
                            Duration = 0,
                            MsisdnId = -2,
                            TypeId = 1
                        },
                        new
                        {
                            SmsTransactionId = -3,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8508),
                            Duration = 0,
                            MsisdnId = -3,
                            TypeId = 1
                        },
                        new
                        {
                            SmsTransactionId = -4,
                            Created = new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8514),
                            Duration = 0,
                            MsisdnId = -4,
                            TypeId = 1
                        },
                        new
                        {
                            SmsTransactionId = -5,
                            Created = new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8518),
                            Duration = 0,
                            MsisdnId = -5,
                            TypeId = 1
                        },
                        new
                        {
                            SmsTransactionId = -6,
                            Created = new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8532),
                            Duration = 0,
                            MsisdnId = -6,
                            TypeId = 1
                        },
                        new
                        {
                            SmsTransactionId = -7,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8539),
                            Duration = 0,
                            MsisdnId = -7,
                            TypeId = 1
                        },
                        new
                        {
                            SmsTransactionId = -8,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8543),
                            Duration = 0,
                            MsisdnId = -8,
                            TypeId = 1
                        },
                        new
                        {
                            SmsTransactionId = -9,
                            Created = new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8548),
                            Duration = 0,
                            MsisdnId = -9,
                            TypeId = 1
                        },
                        new
                        {
                            SmsTransactionId = -10,
                            Created = new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8556),
                            Duration = 0,
                            MsisdnId = -10,
                            TypeId = 1
                        },
                        new
                        {
                            SmsTransactionId = -11,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8562),
                            Duration = 10,
                            MsisdnId = -1,
                            TypeId = 2
                        },
                        new
                        {
                            SmsTransactionId = -12,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8567),
                            Duration = 34,
                            MsisdnId = -2,
                            TypeId = 2
                        },
                        new
                        {
                            SmsTransactionId = -13,
                            Created = new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8572),
                            Duration = 20,
                            MsisdnId = -3,
                            TypeId = 2
                        },
                        new
                        {
                            SmsTransactionId = -14,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8576),
                            Duration = 7,
                            MsisdnId = -4,
                            TypeId = 2
                        },
                        new
                        {
                            SmsTransactionId = -15,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8581),
                            Duration = 34,
                            MsisdnId = -5,
                            TypeId = 2
                        },
                        new
                        {
                            SmsTransactionId = -16,
                            Created = new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8585),
                            Duration = 75,
                            MsisdnId = -6,
                            TypeId = 2
                        },
                        new
                        {
                            SmsTransactionId = -17,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8588),
                            Duration = 68,
                            MsisdnId = -7,
                            TypeId = 2
                        },
                        new
                        {
                            SmsTransactionId = -18,
                            Created = new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8647),
                            Duration = 47,
                            MsisdnId = -8,
                            TypeId = 2
                        },
                        new
                        {
                            SmsTransactionId = -19,
                            Created = new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8652),
                            Duration = 41,
                            MsisdnId = -9,
                            TypeId = 2
                        },
                        new
                        {
                            SmsTransactionId = -20,
                            Created = new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8656),
                            Duration = 40,
                            MsisdnId = -10,
                            TypeId = 2
                        });
                });

            modelBuilder.Entity("DAL.Entities.Type", b =>
                {
                    b.Property<int>("TypeId");

                    b.Property<string>("Name");

                    b.HasKey("TypeId");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            TypeId = 1,
                            Name = "sms"
                        },
                        new
                        {
                            TypeId = 2,
                            Name = "call"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Transactions", b =>
                {
                    b.HasOne("DAL.Entities.Msisdn", "Msisdn")
                        .WithMany()
                        .HasForeignKey("MsisdnId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}