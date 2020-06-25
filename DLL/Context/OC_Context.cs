using DLL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.Context
{
    public class OC_Context : IdentityDbContext
    {
        public OC_Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Organization> Organization { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Person Table
            modelBuilder.Entity<Person>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .HasColumnType("nvarchar(100)")
                .IsRequired();
            modelBuilder.Entity<Person>()
               .Property(e => e.LastName)
               .HasColumnType("nvarchar(100)")
               .IsRequired();
            modelBuilder.Entity<Person>()
               .Property(e => e.Gender)
               .HasColumnType("nvarchar(50)")
               .IsRequired();
            modelBuilder.Entity<Person>()
               .Property(e => e.PersonID)
               .HasColumnType("nvarchar(11)")
               .IsRequired();
            modelBuilder.Entity<Person>()
               .Property(e => e.BirthDate)
               .HasColumnType("smalldatetime")
               .IsRequired();
            modelBuilder.Entity<Person>()
               .Property(e => e.Phone)
               .HasColumnType("nvarchar(13)")
               .IsRequired();
            modelBuilder.Entity<Person>()
               .Property(e => e.Picture)
               .HasColumnType("nvarchar(200)")
               .IsRequired();
            modelBuilder.Entity<Person>()
               .Property(e => e.OrganizationId)
               .HasColumnType("int")
               .IsRequired();
            modelBuilder.Entity<Person>()
               .Property(e => e.Position)
               .HasColumnType("nvarchar(100)")
               .IsRequired();

            //Organization Table
            modelBuilder.Entity<Organization>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Organization>()
              .Property(e => e.Name)
              .HasColumnType("nvarchar(100)")
              .IsRequired();
            modelBuilder.Entity<Organization>()
              .Property(e => e.Name)
              .HasColumnType("nvarchar(100)")
              .IsRequired();
            modelBuilder.Entity<Organization>()
              .Property(e => e.Address)
              .HasColumnType("nvarchar(500)")
              .IsRequired();
            modelBuilder.Entity<Organization>()
              .Property(e => e.Industry)
              .HasColumnType("nvarchar(100)")
              .IsRequired();

            // Connections : Person to Organization (many : one)
            modelBuilder.Entity<Organization>()
                .HasMany(e => e.People)
                .WithOne(e => e.Organization)
                .HasForeignKey(e => e.OrganizationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Seed();
        }
    }
}
