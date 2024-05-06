using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Persistence.Context
{
    public class AppContext : DbContext
    {
        public string _connectionString => Registration.ConnectionString;
        public AppContext()
        {

        }
        public AppContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(_connectionString, opt => { 
                    opt.EnableRetryOnFailure(); 
                });
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().Property(s => s.Id).HasDefaultValue<Guid>();
            modelBuilder.Entity<Course>().Property(c => c.Id).HasDefaultValue<Guid>();
            modelBuilder.Entity<StudentCourse>().Property(sc => sc.Id).HasDefaultValue<Guid>();

            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
        }


    }
}
