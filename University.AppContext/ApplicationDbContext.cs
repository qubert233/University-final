using Microsoft.EntityFrameworkCore;
using System;
using Domain.Entities;

namespace University.AppContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Audience> Audiences { get; set; }
        public DbSet<Lection> Lections { get; set; }
        public DbSet<AudLect> AudLects { get; set; }
        public DbSet<TeachSubj> TeachSubjs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AudLect>()
                .HasKey(x => new { x.AudId, x.LectId, x.GroupId });


            modelBuilder.Entity<AudLect>()
                .HasOne(e => e.Audience)
                .WithMany(e => e.AudLects)
                .HasForeignKey(e => e.AudId);

            modelBuilder.Entity<AudLect>()
                .HasOne(e => e.Lection)
                .WithMany(e => e.AudLects)
                .HasForeignKey(e => e.LectId);

            modelBuilder.Entity<AudLect>()
                .HasOne(e => e.Group)
                .WithMany(e => e.AudLects)
                .HasForeignKey(e => e.GroupId);

            modelBuilder.Entity<TeachSubj>()
                .HasKey(x => new { x.TeacherId, x.SubjId });

            modelBuilder.Entity<TeachSubj>()
                .HasOne(e => e.Teacher)
                .WithMany(e => e.TeachSubj)
                .HasForeignKey(e => e.TeacherId);

            modelBuilder.Entity<TeachSubj>()
                .HasOne(e => e.Subject)
                .WithMany(e => e.TeachSubj)
                .HasForeignKey(e => e.SubjId);

            ApplicationDbContextInitializer.Seed(modelBuilder);
        }

    }
}
