using Microsoft.EntityFrameworkCore;
using SaludPro.Core.Domain.Entities.Cita;
using SaludPro.Core.Domain.Entities.Consultorio;
using SaludPro.Core.Domain.Entities.Laboratorio;
using SaludPro.Core.Domain.Entities.Medico;
using SaludPro.Core.Domain.Entities.Paciente;
using SaludPro.Core.Domain.Entities.Usuario;

namespace SaludPro.Infrastructure.Persistence.Contexts
{
    public class SaludProContext : DbContext
    {
        public SaludProContext(DbContextOptions<SaludProContext> options) : base(options) { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Medicos> Medicos { get; set; }
        public DbSet<Citas> Citas { get; set; }
        public DbSet<Consultorios> Consultorios { get; set; }
        public DbSet<PruebasLaboratorio> PruebasLaboratorio { get; set; }
        public DbSet<ResultadosLaboratorio> ResultadosLaboratorio { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tables
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Pacientes>().ToTable("Pacientes");
            modelBuilder.Entity<Medicos>().ToTable("Medicos");
            modelBuilder.Entity<Citas>().ToTable("Citas");
            modelBuilder.Entity<Consultorios>().ToTable("Consultorios");
            modelBuilder.Entity<PruebasLaboratorio>().ToTable("PruebasLaboratorio");
            modelBuilder.Entity<ResultadosLaboratorio>().ToTable("ResultadosLaboratorio");
            #endregion

            #region PrimaryKeys
            modelBuilder.Entity<Usuarios>().HasKey(u => u.Id);
            modelBuilder.Entity<Pacientes>().HasKey(p => p.Id);
            modelBuilder.Entity<Medicos>().HasKey(m => m.Id);
            modelBuilder.Entity<Citas>().HasKey(c => c.Id);
            modelBuilder.Entity<Consultorios>().HasKey(c => c.Id);
            modelBuilder.Entity<PruebasLaboratorio>().HasKey(pl => pl.Id);
            modelBuilder.Entity<ResultadosLaboratorio>().HasKey(rl => rl.Id);
            #endregion

            #region Relationships

            modelBuilder.Entity<Usuarios>()
                .HasOne(u => u.Consultorio)
                .WithMany(c => c.Usuarios)
                .HasForeignKey(u => u.ConsultorioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pacientes>()
                .HasOne(p => p.Consultorio)
                .WithMany()
                .HasForeignKey(p => p.ConsultorioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Medicos>()
                .HasOne(m => m.Consultorio)
                .WithMany(c => c.Medicos)
                .HasForeignKey(m => m.ConsultorioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Citas>()
                .HasOne(c => c.Paciente)
                .WithMany()
                .HasForeignKey(c => c.PacienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Citas>()
                .HasOne(c => c.Medico)
                .WithMany()
                .HasForeignKey(c => c.MedicoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PruebasLaboratorio>()
                .HasOne(pl => pl.Consultorio)
                .WithMany()
                .HasForeignKey(pl => pl.ConsultorioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResultadosLaboratorio>()
                .HasOne(rl => rl.Cita)
                .WithMany()
                .HasForeignKey(rl => rl.CitaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ResultadosLaboratorio>()
                .HasOne(rl => rl.Prueba)
                .WithMany()
                .HasForeignKey(rl => rl.PruebaId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region configurations
            #region Usuarios
            modelBuilder.Entity<Usuarios>().Property(u => u.NombreUsuario).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Usuarios>().HasIndex(u => u.NombreUsuario).IsUnique();

            modelBuilder.Entity<Usuarios>().Property(u => u.Contraseña).HasMaxLength(255).IsRequired();
            #endregion

            #region Pacientes
            modelBuilder.Entity<Pacientes>().Property(p => p.Cedula).HasMaxLength(11).IsRequired();

            modelBuilder.Entity<Pacientes>().HasIndex(p => p.Cedula).IsUnique();

            modelBuilder.Entity<Pacientes>().Property(p => p.Direccion).HasMaxLength(255).IsRequired();

            modelBuilder.Entity<Pacientes>().Property(p => p.Alergias).IsRequired();
            #endregion

            #region Medicos
            modelBuilder.Entity<Medicos>().Property(m => m.Cedula).HasMaxLength(11).IsRequired();

            modelBuilder.Entity<Medicos>().HasIndex(m => m.Cedula).IsUnique();
            #endregion

            #region Citas
            modelBuilder.Entity<Citas>()
                .Property(c => c.Fecha)
                .IsRequired();

            modelBuilder.Entity<Citas>()
                .Property(c => c.Hora)
                .HasMaxLength(5)
                .IsRequired();

            modelBuilder.Entity<Citas>()
                .Property(c => c.Causa)
                .HasMaxLength(255)
                .IsRequired();
            #endregion

            #region Pruebas de Laboratorio
            modelBuilder.Entity<PruebasLaboratorio>()
                .Property(pl => pl.NombrePrueba)
                .HasMaxLength(255)
                .IsRequired();
            #endregion

            #region Consultorios
            modelBuilder.Entity<Consultorios>()
                .Property(c => c.NombreConsultorio)
                .HasMaxLength(150)
                .IsRequired();
            #endregion
            #endregion

            base.OnModelCreating(modelBuilder);
        }

    }
}
