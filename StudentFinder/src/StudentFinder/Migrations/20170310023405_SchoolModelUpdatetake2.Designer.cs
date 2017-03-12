using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StudentFinder.Data;

namespace StudentFinder.Migrations
{
    [DbContext(typeof(StudentFinderContext))]
    [Migration("20170310023405_SchoolModelUpdatetake2")]
    partial class SchoolModelUpdatetake2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentFinder.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("From");

                    b.Property<string>("Label");

                    b.Property<int?>("ScheduleId");

                    b.Property<int?>("SpaceId");

                    b.Property<string>("To");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SpaceId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("StudentFinder.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Contact");

                    b.Property<string>("Domain");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("School");
                });

            modelBuilder.Entity("StudentFinder.Models.Space", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SpaceId");

                    b.Property<int?>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("SpaceId");

                    b.HasIndex("StudentId");

                    b.ToTable("Space");
                });

            modelBuilder.Entity("StudentFinder.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GradeLevel");

                    b.Property<int?>("ScheduleId");

                    b.Property<int>("SchoolId");

                    b.Property<int>("StudentId");

                    b.Property<string>("fName");

                    b.Property<string>("lName");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentFinder.Models.Schedule", b =>
                {
                    b.HasOne("StudentFinder.Models.Schedule")
                        .WithMany("Schedules")
                        .HasForeignKey("ScheduleId");

                    b.HasOne("StudentFinder.Models.Space", "Space")
                        .WithMany()
                        .HasForeignKey("SpaceId");
                });

            modelBuilder.Entity("StudentFinder.Models.Space", b =>
                {
                    b.HasOne("StudentFinder.Models.Space")
                        .WithMany("Spaces")
                        .HasForeignKey("SpaceId");

                    b.HasOne("StudentFinder.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("StudentFinder.Models.Student", b =>
                {
                    b.HasOne("StudentFinder.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId");

                    b.HasOne("StudentFinder.Models.Student")
                        .WithMany("Students")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
