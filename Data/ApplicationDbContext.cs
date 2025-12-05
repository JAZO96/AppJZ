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

        // DbSets de tus modelos existentes
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

            // Charset y collation global
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            // ⬇️ CONFIGURACIÓN DE TABLA ASPNETUSERS (Identity)
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("AspNetUsers");

                // Campos personalizados
                entity.Property(e => e.Nombre).HasColumnName("nombre");
                entity.Property(e => e.Apellido).HasColumnName("apellido");
                entity.Property(e => e.NumeroDocumento).HasColumnName("numero_documento");
                entity.Property(e => e.RolId).HasColumnName("rol_id");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipo_documento_id");
                entity.Property(e => e.Imagen).HasColumnName("imagen");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                // índice único
                entity.HasIndex(e => e.NumeroDocumento).IsUnique();
            });

            // CONFIGURACIÓN Administracionescolar
            modelBuilder.Entity<Administracionescolar>(entity =>
            {
                entity.ToTable("administracionescolar");
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.HasOne(a => a.Estudiante)
                    .WithMany(u => u.AdministracionescolarEstudiantes)
                    .HasForeignKey(a => a.EstudianteId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(a => a.Docente)
                    .WithMany(u => u.AdministracionescolarDocentes)
                    .HasForeignKey(a => a.DocenteId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(a => a.Grado)
                    .WithMany(g => g.Administracionescolars)
                    .HasForeignKey(a => a.GradoId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // RESTO DE ENTIDADES
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
        }
    }
}
