using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EyeSurgeryClinic.Data.Models;

namespace EyeSurgeryClinic.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Surgery> Surgeries { get; set; }
        public DbSet<SurgeryType> SurgeryTypes { get; set; }
    }
}