
using System;
using System.Collections.Generic;
using domain.models;
using Microsoft.EntityFrameworkCore;

namespace storage
{
    public class WorkOutBuddyContext : DbContext
    {
        public DbSet<AccountModel> Accounts {get; set;}

        public DbSet<CardModel> Cards {get;set;}

        //Setup for dependency injection. The db to context
        public WorkOutBuddyContext(DbContextOptions<WorkOutBuddyContext> options) : base(options){}
        //public WorkOutBuddyContext() {}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AccountModel>().HasKey(s => s.EnitityId);
            builder.Entity<CardModel>().HasKey(s => s.EnitityId);
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

            builder.Entity<CardModel>().HasData(new List<CardModel>
            {
                new CardModel(){
                    EnitityId = 1,
                    Name = "Lightning Bolt",
                    CardType = "Instant",
                    ManaCost = "R",
                    PowerToughness = "N/A",
                    ImagePath = "https://www.google.com/search?tbs=sbi:AMhZZivdILz9U0HsPhVAibP0jYIrjMxd8mFfMqs4fJyBH5hDBD8PvaTs3vbffBYMAsMRTysDIfxko5FG04feQrF4Px7dtvvCXJmr0_1NZDX_1NfJAKpMYRto_14Cu--Lktu1nT2kFB5OFshEvyc9QMJsFMioUSxfwxXY0jJEeGnNsRFJn8LsKzU3Y3L-FsiZ6q2oikJhMMxNQHZrhghNbXIzkXP0eSKZRujSm19dXWjO8aydqb300XNbUFev3ZojsE8wRs2wo-ecol1NyJLeOX0l3_1PNld3uankMqDgMAqthmqACqt8c7qFn7jN84mTiADso-2KFlP5gUXRewCKB9M0YbNF2NuyCbdm6FkmyKVdYjzBKCEB7NKMyzuXKlzfV_1OaFipiYGCxR4ZO99jMwOR8YYPQHD3juzEHzw"

                }
            });
        }

    }
}