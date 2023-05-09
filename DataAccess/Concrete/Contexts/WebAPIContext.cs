using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace DataAccess.Concrete.Contexts
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext(DbContextOptions<WebAPIContext> options) : base(options)
        {
            
        }

        public WebAPIContext()
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
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<School>().ToTable("School");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
            modelBuilder.Entity<Branch>().ToTable("Branch");
            modelBuilder.Entity<Classroom>().ToTable("Classroom");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<District>().ToTable("District");
            modelBuilder.Entity<Lesson>().ToTable("Lesson");
            modelBuilder.Entity<Neighbourhood>().ToTable("Neighbourhood");
            modelBuilder.Entity<Province>().ToTable("Province");
            modelBuilder.Entity<Region>().ToTable("Region");
            modelBuilder.Entity<Student>().ToTable("Student");
        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Branch> Branchs { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Neighbourhood> Neighbourhoods { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
