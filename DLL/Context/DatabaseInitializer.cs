using DLL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.Context
{
    public static class DatabaseInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Person DataInitializer
            modelBuilder.Entity<Person>()
              .HasData(
                new Person
                {
                    Id = 1,
                    FirstName = "Giorgi",
                    LastName = "Bezhanishvili",
                    Gender = "Male",
                    PersonID = "54001055099",
                    BirthDate = new DateTime(1997, 12, 06),
                    City = "Chiatura",
                    Phone = "+995555718374",
                    Picture = "noimage.png",
                    OrganizationId = 1,
                    Position = "Web Developer"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Jumberi",
                    LastName = "Aravidze",
                    Gender = "Male",
                    PersonID = "54001066666",
                    BirthDate = new DateTime(1995, 11, 21),
                    City = "Tbilisi",
                    Phone = "+995123123456",
                    Picture = "noimage.png",
                    OrganizationId = 2,
                    Position = "Accoutant"
                },
                new Person
                {
                    Id = 3,
                    FirstName = "Pelagia",
                    LastName = "Tavadishvili",
                    Gender = "Female",
                    PersonID = "56001055555",
                    BirthDate = new DateTime(1991, 06, 05),
                    City = "Batumi",
                    Phone = "+995555123456",
                    Picture = "noimage.png",
                    OrganizationId = 1,
                    Position = "HR"
                }
                );

            //Organization DataInitializer
            modelBuilder.Entity<Organization>()
                .HasData(
                new Organization
                {
                    Id = 1,
                    Name = "Microsoft(Chiatura Office)",
                    Address = "Akaki Tseretlis #15",
                    Industry = "IT",
                    Logo = "nologo.png"
                },
                new Organization
                {
                    Id = 2,
                    Name = "McDonald's",
                    Address = "Dadianis #17",
                    Industry = "Restaurant",
                    Logo = "nologo.png"
                }
                );
        }
    }
}
