using Medicio.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Medicio.DLL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany()
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Department)
                .WithMany()
                .HasForeignKey(a => a.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict); 
        }
        public DbSet<Service> Services {  get; set; }
        public DbSet<Departments> departments { get; set; }
        public DbSet<Doctors>  doctors{ get; set; }
        public DbSet<Testimonials> testimonials { get; set; }
        public DbSet<Questions> questions { get; set; }
        public DbSet<Pricing>  pricings { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Slider>  sliders { get; set; }
        public DbSet<Features>  features { get; set; }

        

    }
}
