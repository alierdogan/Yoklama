using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace DataAccess.Concrete.Contexts
{
    public class YoklamaContext : DbContext
    {
        public YoklamaContext(DbContextOptions<YoklamaContext> options) : base(options)
        {
            
        }

        public YoklamaContext()
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string conString = @"Data Source=127.0.0.1,1401; User ID=sa; Password=Aa123456; Initial Catalog=Yoklama; Trusted_Connection=True; TrustServerCertificate=True; Persist Security Info=True; Integrated Security=False;";
            //optionsBuilder.UseSqlServer(conString);
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("YoklamaDb"));
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("YoklamaDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("PERSON");
            modelBuilder.Entity<User>().ToTable("USER");
            modelBuilder.Entity<School>().ToTable("SCHOOL");
            modelBuilder.Entity<Teacher>().ToTable("TEACHER");
            modelBuilder.Entity<Branch>().ToTable("BRANCH");
            modelBuilder.Entity<Classroom>().ToTable("CLASSROOM");
            modelBuilder.Entity<Department>().ToTable("DEPARTMENT");
            modelBuilder.Entity<District>().ToTable("DISTRICT");
            modelBuilder.Entity<Lesson>().ToTable("LESSON");
            modelBuilder.Entity<Neighbourhood>().ToTable("NEIGHBOURHOOD");
            modelBuilder.Entity<Province>().ToTable("PROVINCE");
            modelBuilder.Entity<Region>().ToTable("REGION");
            modelBuilder.Entity<Student>().ToTable("STUDENT");
            modelBuilder.Entity<StudentTimeTable>().ToTable("STUDENT_TIMETABLE");
            modelBuilder.Entity<SchoolTeacher>().ToTable("SCHOOL_TEACHER");
        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Branch> Branchs { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        //public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Neighbourhood> Neighbourhoods { get; set; }
        public virtual DbSet<StudentTimeTable> StudentTimeTables { get; set; }
        public virtual DbSet<SchoolTeacher> SchoolTeachers { get; set; }
    }
}
