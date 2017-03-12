using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentFinder.Models;

namespace StudentFinder.Data
{
    public class StudentFinderContext : DbContext
    {
        public StudentFinderContext()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentScheduleSpace>().HasKey(s => new { s.StudentId, s.ScheduleId, s.SpaceId });
            //modelBuilder.Entity<Schedule>().HasMany(x => x.Student).WithOne(x => x.Space)
            //.Map(x =>
            //{
            //    x.ToTable("Student"); // third table is named Cookbooks
            //    x.MapKey("ScheduleId");
            //    x.MapRightKey("SpaceId");
            //});
        }

        public StudentFinderContext(DbContextOptions<StudentFinderContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        //public DbSet<CentralModel> Central { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Space> Space { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
