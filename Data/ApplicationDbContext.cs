using AppJZ.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppJZ.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets de todas tus entidades en /Models
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Actividadevaluacion> Actividadevaluacions { get; set; }
        public DbSet<Administracionescolar> Administracionescolars { get; set; }
        public DbSet<Bibliotecaalmacen> Bibliotecaalmacens { get; set; }
        public DbSet<Datosadicionale> Datosadicionales { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Documentacion> Documentacions { get; set; }
        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<Gestionacademica> Gestionacademicas { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Gradomaterium> Gradomateria { get; set; }
        public DbSet<Materium> Materia { get; set; }
        public DbSet<Matriculafinanza> Matriculafinanzas { get; set; }
        public DbSet<Observadoralumno> Observadoralumnos { get; set; }
        public DbSet<Parentesco> Parentescos { get; set; }
        public DbSet<Periodoacademico> Periodoacademicos { get; set; }
        public DbSet<Tipoactividad> Tipoactividads { get; set; }
        public DbSet<Tipodocumento> Tipodocumentos { get; set; }
        public DbSet<Tipodocumentoacademico> Tipodocumentoacademicos { get; set; }
        public DbSet<Tipomaterial> Tipomaterials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            // Configurar ApplicationUser para que use la tabla usuario existente
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("usuario");

                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Ignore(e => e.PhoneNumber);
                entity.Ignore(e => e.PhoneNumberConfirmed);
                entity.Ignore(e => e.TwoFactorEnabled);

            // Índices
            entity.HasIndex(e => e.NumeroDocumento, "numero_documento").IsUnique();
                entity.HasIndex(e => e.RolId, "rol_id");
                entity.HasIndex(e => e.TipoDocumentoId, "tipo_documento_id");

                // Relación con Rol
                entity.HasOne(u => u.Rol)
                    .WithMany()
                    .HasForeignKey(u => u.RolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("usuario_ibfk_2");

                // Relación con TipoDocumento
                entity.HasOne(u => u.TipoDocumento)
                    .WithMany()
                    .HasForeignKey(u => u.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("usuario_ibfk_1");
            });

            // Configurar Administracionescolar con múltiples relaciones
            modelBuilder.Entity<Administracionescolar>(entity =>
            {
                entity.ToTable("administracionescolar");

                entity.HasKey(e => e.Id).HasName("PRIMARY");

                // Estudiante
                entity.HasOne(a => a.Estudiante)
                    .WithMany(u => u.AdministracionescolarEstudiantes)
                    .HasForeignKey(a => a.EstudianteId)
                    .OnDelete(DeleteBehavior.Restrict);

                // Docente
                entity.HasOne(a => a.Docente)
                    .WithMany(u => u.AdministracionescolarDocentes)
                    .HasForeignKey(a => a.DocenteId)
                    .OnDelete(DeleteBehavior.Restrict);

                // Grado
                entity.HasOne(a => a.Grado)
                    .WithMany(g => g.Administracionescolars)
                    .HasForeignKey(a => a.GradoId)
                    .OnDelete(DeleteBehavior.Restrict);
            });


            // Configurar otras entidades
            ConfigurarEntidades(modelBuilder);
        }

        private void ConfigurarEntidades(ModelBuilder modelBuilder)
        {
            // Rol
            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("rol");
            });

            // Actividadevaluacion
            modelBuilder.Entity<Actividadevaluacion>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("actividadevaluacion");

                entity.HasOne(d => d.TipoActividad)
                    .WithMany(p => p.Actividadevaluacions)
                    .HasForeignKey(d => d.TipoActividadId);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Actividadevaluacions)
                    .HasForeignKey(d => d.UsuarioId);
            });

            // Grado
            modelBuilder.Entity<Grado>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("grado");

                entity.HasOne(d => d.Docente)
                    .WithMany()
                    .HasForeignKey(d => d.DocenteId);
            });

            // Agregar configuraciones para las demás entidades...
        }
    }
}