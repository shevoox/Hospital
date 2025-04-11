using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Doctor>().HasData(new List<Doctor>
            {
                new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiologist", Img = "doctor1.jpg" },
                new Doctor { Id = 2, Name = "Dr. Robert Williams", Specialization = "Neurologist", Img = "doctor2.jpg" },
                new Doctor { Id = 3, Name = "Dr. Emma Wilson", Specialization = "Pediatrician", Img = "doctor3.jpg" },
                new Doctor { Id = 4, Name = "Dr. Michael Chen", Specialization = "Dermatologist", Img = "doctor4.jpg" },
                new Doctor { Id = 5, Name = "Dr. Sarah Johnson", Specialization = "Cardiologist", Img = "doctor1.jpg" },
                new Doctor { Id = 6, Name = "Dr. David Brown", Specialization = "Neurologist", Img = "doctor2.jpg" },
                new Doctor { Id = 7, Name = "Dr. Lisa Anderson", Specialization = "Pediatrician", Img = "doctor3.jpg" },
                new Doctor { Id = 8, Name = "Dr. Mark Taylor", Specialization = "Dermatologist", Img = "doctor4.jpg" }
            });
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}