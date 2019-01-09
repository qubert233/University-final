using Microsoft.EntityFrameworkCore;
using System;
using Domain.Entities;
using System.Collections.Generic;

namespace University.AppContext
{
    //DropCreateDatabaseAlways<MyAppDbContext>
    //DropCreateDatabaseIfModelChanges<MyAppDbContext>
    //CreateDatabaseIfNotExists<MyAppDbContext>

    public static class ApplicationDbContextInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                                new Department { Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33181"), Name = "Software Testing " },
                                new Department { Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33182"), Name = "Programming and System Analysis" }
                            );
            modelBuilder.Entity<Subject>().HasData(
                                new Subject { Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33183"), Name = "Calculus" },
                                new Subject { Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33184"), Name = "Math Analysis" },
                                new Subject { Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33185"), Name = "Operation Systems" },
                                new Subject { Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33186"), Name = "Databases Theory" },
                                new Subject { Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33187"), Name = "Application Testing" }
                );
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33283"),
                    FirstName = "Max",
                    LastName = "Frei",
                    MiddleName = "Unknown"

                },
                new Teacher
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33383"),
                    FirstName = "Tyler",
                    LastName = "Durden",
                    MiddleName = "Unknown",
                },
                new Teacher
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33483"),
                    FirstName = "Dean",
                    LastName = "Moriarty",
                    MiddleName = "Unknown",
                },
                new Teacher
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33583"),
                    FirstName = "Sal",
                    LastName = "Paradise",
                    MiddleName = "Unknown",
                }
                );
            modelBuilder.Entity<Teacher>().HasData(
                new TeachSubj
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad03280"),
                    TeacherId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33283"),
                    SubjId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33183")
                },
                new TeachSubj
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad13280"),
                    TeacherId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33283"),
                    SubjId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33184")
                },
                new TeachSubj
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad23280"),
                    TeacherId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33383"),
                    SubjId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33185")
                },
                new TeachSubj
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33280"),
                    TeacherId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33383"),
                    SubjId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33186")
                },
                new TeachSubj
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad43280"),
                    TeacherId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33483"),
                    SubjId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33187")
                },
                new TeachSubj
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad53280"),
                    TeacherId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33583"),
                    SubjId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33184")
                },
                new TeachSubj
                {
                    Id = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad63280"),
                    TeacherId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33383"),
                    SubjId = new Guid("ed0758d1-0d55-4a99-8c21-4f147ad33186")
                }
                );

        }
    }
}
