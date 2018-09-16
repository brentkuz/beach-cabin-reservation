﻿using BeachCabinReservation.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeachCabinReservation.Data
{
    public class AppDataContext : IdentityDbContext<AppUser>
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        public DbSet<LogEntry> LogEntries { get; set; }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            AddTimestamps();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<LogEntry>().HasData(
                new LogEntry
                {
                    Id = 1,
                    Level = LogLevel.Information,
                    Message = "Initial test message",
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    CreatedBy = "test",
                    ModifiedBy = "test"
                }
            );
        }
        private void AddTimestamps()
        {
            //TODO: implement
        }

    }
}