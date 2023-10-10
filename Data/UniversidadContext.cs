
using Microsoft.EntityFrameworkCore;
using Entities;
using Microsoft.Extensions.Logging;
using System.Reflection.Metadata;

namespace Data
{

    public class UniversidadContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Plan> Planes { get; set; }

        public DbSet<Especialidad> Especialidades { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Comision> Comisiones { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
                .LogTo(Console.WriteLine, LogLevel.Information)
                .UseSqlServer(
                    @"Server=localhost;Database=Universidad ;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");

        // @"Server=(localdb)\MSSQLLocalDB;Database=Universidad;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=true"
        public UniversidadContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especialidad>()
                .HasMany(e => e.Planes)
                .WithOne(p => p.Especialidad)
                .HasForeignKey("idEspecialidad")
                .IsRequired();

            modelBuilder.Entity<Plan>()
                .HasMany(p => p.Alumnos)
                .WithOne(p => p.Plan)
                .HasForeignKey("idPlan")
                .IsRequired();

            modelBuilder.Entity<Plan>()
                .HasMany(m => m.Materias)
                .WithOne(p => p.Plan)
                .HasForeignKey("idPlan")
                .IsRequired();

            modelBuilder.Entity<Plan>()
                .HasMany(c => c.Comisiones)
                .WithOne(p => p.Plan)
                .HasForeignKey("idPlan")
                .IsRequired();
        }



    }
}
