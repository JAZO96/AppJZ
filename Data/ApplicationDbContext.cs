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

            // Configurar ApplicationUser SIN crear FK en la migración
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("aspnetusers");

                // ⚠️ IGNORAR las relaciones de navegación temporalmente
                entity.Ignore(u => u.Rol);
                entity.Ignore(u => u.TipoDocumento);

                // Ignorar colecciones de navegación
                entity.Ignore(u => u.Actividadevaluacions);
                entity.Ignore(u => u.Documentacions);
                entity.Ignore(u => u.Matriculafinanzas);
                entity.Ignore(u => u.Gestionacademicas);
                entity.Ignore(u => u.ObservadoralumnoUsuarios);
                entity.Ignore(u => u.AdministracionescolarEstudiantes);
                entity.Ignore(u => u.AdministracionescolarDocentes);

                entity.HasIndex(e => e.NumeroDocumento).IsUnique();
            });

            // Configurar otras entidades también ignorando las relaciones con ApplicationUser
            modelBuilder.Entity<Administracionescolar>(entity =>
            {
                entity.ToTable("administracionescolar");
                entity.HasKey(e => e.Id);

                entity.Ignore(a => a.Estudiante);
                entity.Ignore(a => a.Docente);

                entity.HasOne(a => a.Grado)
                    .WithMany(g => g.Administracionescolars)
                    .HasForeignKey(a => a.GradoId)
                    .IsRequired(false);
            });

            modelBuilder.Entity<Actividadevaluacion>(entity =>
            {
                entity.ToTable("actividadevaluacion");
                entity.Ignore(a => a.Usuario);
            });

            modelBuilder.Entity<Documentacion>(entity =>
            {
                entity.ToTable("documentacion");
                entity.Ignore(d => d.Usuario);
            });

            modelBuilder.Entity<Gestionacademica>(entity =>
            {
                entity.ToTable("gestionacademica");
                entity.Ignore(g => g.Usuario);
            });

            modelBuilder.Entity<Matriculafinanza>(entity =>
            {
                entity.ToTable("matriculafinanzas");
                entity.Ignore(m => m.Usuario);
            });

            modelBuilder.Entity<Observadoralumno>(entity =>
            {
                entity.ToTable("observadoralumno");
                entity.Ignore(o => o.Usuario);
            });

            // Otras entidades
            modelBuilder.Entity<Rol>().ToTable("rol");
            modelBuilder.Entity<Grado>().ToTable("grado");
            modelBuilder.Entity<Docente>().ToTable("docentes");
            modelBuilder.Entity<Tipodocumento>().ToTable("tipodocumento");
        }
    }
}