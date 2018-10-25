using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class BankModel : DbContext
    {
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccountNumber)
                      .HasName("PK_Accounts");

                entity.Property(e => e.AccountNumber)
                     .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailAddress)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.ToTable("Accounts");
            });
        }

    }
}
