
using System;
using System.Collections.Generic;
using domain.models;
using Microsoft.EntityFrameworkCore;

namespace storage
{
    public class WorkOutBuddyContext : DbContext
    {
        public DbSet<AccountModel> Accounts {get; set;}

        //Setup for dependency injection. The db to context
        public WorkOutBuddyContext(DbContextOptions<WorkOutBuddyContext> options) : base(options){}
        public WorkOutBuddyContext() {}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AccountModel>().HasKey(s => s.EnitityId);
            SeedData(builder);
        }

        protected void SeedData(ModelBuilder builder)
        {
            builder.Entity<AccountModel>().HasData(new List<AccountModel>
            {
                new AccountModel() {
                    EnitityId = -1,
                    Email = "Taylor@live.com", 
                    FirstName = "Taylor", 
                    LastName = "Stoltzfus", 
                    DateJoined = new DateTime()
                    },
                new AccountModel() {
                    EnitityId = -2,
                    Email = "Faker@live.com", 
                    FirstName = "James", 
                    LastName = "Stoltzfus", 
                    DateJoined = new DateTime()
                    },
            });
        }

    }
}