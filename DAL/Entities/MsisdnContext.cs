using Common.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class MsisdnContext : DbContext
    {
        public MsisdnContext(DbContextOptions<MsisdnContext> options) : base(options)
        {
        }

        public DbSet<Msisdn> Msisdns { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Msisdn>(entity =>
            {
                entity.HasIndex(e => e.Number).IsUnique();
            });

            var msisdnList = new List<Msisdn>();
            var startNumber = 370623000000;

            for (var i = 1; i <= 10; i++)
            {
                msisdnList.Add(new Msisdn
                {
                    MsisdnId = -i,
                    Number = startNumber + i
                });
            }

            modelBuilder.Entity<Msisdn>().HasData(msisdnList);

            modelBuilder.Entity<Type>().HasData(
              new Type() { TypeId = 1, Name = "sms" },
              new Type() { TypeId = 2, Name = "call" }
              );

            var transList = new List<Transactions>();

            var r = new Random();

            //sms
            for (var i = 0; i < 10; i++)
            {
                transList.Add(new Transactions
                {
                    SmsTransactionId = -(i + 1),
                    MsisdnId = msisdnList[i].MsisdnId,
                    TypeId = (int)TransactionType.Sms,
                    Duration = 0,
                    Created = DateTime.Now.AddDays(-r.Next(2))
                });
            }

            //call
            for (var i = 0; i < 10; i++)
            {
                transList.Add(new Transactions
                {
                    SmsTransactionId = -((i + 10) + 1),
                    MsisdnId = msisdnList[i].MsisdnId,
                    TypeId = (int)TransactionType.Call,
                    Duration = r.Next(0, 100),
                    Created = DateTime.Now.AddDays(-r.Next(2))
                });
            }

            modelBuilder.Entity<Transactions>().HasData(transList);
        }
    }
}
