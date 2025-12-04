using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace AppJZ.Models;

public partial class AulalinkContext : DbContext
{
    public AulalinkContext()
    {
    }

    public AulalinkContext(DbContextOptions<AulalinkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actividadevaluacion> Actividadevaluacions { get; set; }

    public virtual DbSet<Administracionescolar> Administracionescolars { get; set; }

    public virtual DbSet<Bibliotecaalmacen> Bibliotecaalmacens { get; set; }

    public virtual DbSet<Datosadicionale> Datosadicionales { get; set; }

    public virtual DbSet<Docente> Docentes { get; set; }

    public virtual DbSet<Documentacion> Documentacions { get; set; }

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }

    public virtual DbSet<Formulario> Formularios { get; set; }

    public virtual DbSet<Gestionacademica> Gestionacademicas { get; set; }

    public virtual DbSet<Grado> Grados { get; set; }

    public virtual DbSet<Gradomaterium> Gradomateria { get; set; }

    public virtual DbSet<Materium> Materia { get; set; }

    public virtual DbSet<Matriculafinanza> Matriculafinanzas { get; set; }

    public virtual DbSet<Observadoralumno> Observadoralumnos { get; set; }

    public virtual DbSet<Parentesco> Parentescos { get; set; }

    public virtual DbSet<Periodoacademico> Periodoacademicos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Tipoactividad> Tipoactividads { get; set; }

    public virtual DbSet<Tipodocumento> Tipodocumentos { get; set; }

    public virtual DbSet<Tipodocumentoacademico> Tipodocumentoacademicos { get; set; }

    public virtual DbSet<Tipomaterial> Tipomaterials { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=aulalink;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Actividadevaluacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("actividadevaluacion");

            entity.HasIndex(e => e.TipoActividadId, "tipo_actividad_id");

            entity.HasIndex(e => e.UsuarioId, "usuario_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.TipoActividadId)
                .HasColumnType("int(11)")
                .HasColumnName("tipo_actividad_id");
            entity.Property(e => e.UsuarioId)
                .HasColumnType("int(11)")
                .HasColumnName("usuario_id");

            entity.HasOne(d => d.TipoActividad).WithMany(p => p.Actividadevaluacions)
                .HasForeignKey(d => d.TipoActividadId)
                .HasConstraintName("actividadevaluacion_ibfk_1");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Actividadevaluacions)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("actividadevaluacion_ibfk_2");
        });

        modelBuilder.Entity<Administracionescolar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("administracionescolar");

            entity.HasIndex(e => e.DocenteId, "docente_id");

            entity.HasIndex(e => e.EstudianteId, "estudiante_id");

            entity.HasIndex(e => e.GradoId, "grado_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DocenteId)
                .HasColumnType("int(11)")
                .HasColumnName("docente_id");
            entity.Property(e => e.EstudianteId)
                .HasColumnType("int(11)")
                .HasColumnName("estudiante_id");
            entity.Property(e => e.GradoId)
                .HasColumnType("int(11)")
                .HasColumnName("grado_id");

            entity.HasOne(d => d.Docente).WithMany(p => p.AdministracionescolarDocentes)
                .HasForeignKey(d => d.DocenteId)
                .HasConstraintName("administracionescolar_ibfk_1");

            entity.HasOne(d => d.Estudiante).WithMany(p => p.AdministracionescolarEstudiantes)
                .HasForeignKey(d => d.EstudianteId)
                .HasConstraintName("administracionescolar_ibfk_3");

            entity.HasOne(d => d.Grado).WithMany(p => p.Administracionescolars)
                .HasForeignKey(d => d.GradoId)
                .HasConstraintName("administracionescolar_ibfk_2");
        });

        modelBuilder.Entity<Bibliotecaalmacen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bibliotecaalmacen");

            entity.HasIndex(e => e.TipoMaterialId, "tipo_material_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cantidad)
                .HasColumnType("int(11)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Disponible)
                .HasDefaultValueSql("'1'")
                .HasColumnName("disponible");
            entity.Property(e => e.NombreMaterial)
                .HasMaxLength(100)
                .HasColumnName("nombre_material");
            entity.Property(e => e.TipoMaterialId)
                .HasColumnType("int(11)")
                .HasColumnName("tipo_material_id");

            entity.HasOne(d => d.TipoMaterial).WithMany(p => p.Bibliotecaalmacens)
                .HasForeignKey(d => d.TipoMaterialId)
                .HasConstraintName("bibliotecaalmacen_ibfk_1");
        });

        modelBuilder.Entity<Datosadicionale>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PRIMARY");

            entity.ToTable("datosadicionales");

            entity.HasIndex(e => e.Grado, "grado");

            entity.HasIndex(e => e.ParentescoId, "parentesco_id");

            entity.Property(e => e.UsuarioId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("usuario_id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .HasColumnName("direccion");
            entity.Property(e => e.Grado)
                .HasColumnType("int(20)")
                .HasColumnName("grado");
            entity.Property(e => e.NombreAcudiente)
                .HasMaxLength(100)
                .HasColumnName("nombre_acudiente");
            entity.Property(e => e.NumeroAcudiente)
                .HasMaxLength(10)
                .HasColumnName("numero_acudiente");
            entity.Property(e => e.ParentescoId)
                .HasColumnType("int(11)")
                .HasColumnName("parentesco_id");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .HasColumnName("telefono");

            entity.HasOne(d => d.GradoNavigation).WithMany(p => p.Datosadicionales)
                .HasForeignKey(d => d.Grado)
                .HasConstraintName("datosadicionales_ibfk_3");

            entity.HasOne(d => d.Parentesco).WithMany(p => p.Datosadicionales)
                .HasForeignKey(d => d.ParentescoId)
                .HasConstraintName("datosadicionales_ibfk_2");

            entity.HasOne(d => d.Usuario).WithOne(p => p.Datosadicionale)
                .HasForeignKey<Datosadicionale>(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("datosadicionales_ibfk_1");
        });

        modelBuilder.Entity<Docente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("docente");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Documentacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("documentacion");

            entity.HasIndex(e => e.TipoDocumentoId, "tipo_documento_id");

            entity.HasIndex(e => e.UsuarioId, "usuario_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.TipoDocumentoId)
                .HasColumnType("int(11)")
                .HasColumnName("tipo_documento_id");
            entity.Property(e => e.UsuarioId)
                .HasColumnType("int(11)")
                .HasColumnName("usuario_id");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.Documentacions)
                .HasForeignKey(d => d.TipoDocumentoId)
                .HasConstraintName("documentacion_ibfk_1");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Documentacions)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("documentacion_ibfk_2");
        });

        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__efmigrationshistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Formulario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("formulario");

            entity.HasIndex(e => e.RolId, "rol_id");

            entity.HasIndex(e => e.TipoDocumentoId, "tipo_documento_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroDocumento)
                .HasColumnType("int(11)")
                .HasColumnName("numero_documento");
            entity.Property(e => e.RolId)
                .HasColumnType("int(11)")
                .HasColumnName("rol_id");
            entity.Property(e => e.TipoDocumentoId)
                .HasColumnType("int(11)")
                .HasColumnName("tipo_documento_id");

            entity.HasOne(d => d.Rol).WithMany(p => p.Formularios)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("formulario_ibfk_2");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.Formularios)
                .HasForeignKey(d => d.TipoDocumentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("formulario_ibfk_1");
        });

        modelBuilder.Entity<Gestionacademica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gestionacademica");

            entity.HasIndex(e => e.UsuarioId, "usuario_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.GruposTrabajo)
                .HasColumnType("text")
                .HasColumnName("grupos_trabajo");
            entity.Property(e => e.RegistrarActividades)
                .HasColumnType("text")
                .HasColumnName("registrar_actividades");
            entity.Property(e => e.UsuarioId)
                .HasColumnType("int(11)")
                .HasColumnName("usuario_id");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Gestionacademicas)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("gestionacademica_ibfk_1");
        });

        modelBuilder.Entity<Grado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("grado");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Creditos).HasColumnType("int(11)");
            entity.Property(e => e.DocenteId).HasColumnType("int(11)");
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.Nivel).HasMaxLength(100);
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Gradomaterium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gradomateria");

            entity.HasIndex(e => new { e.GradoId, e.MateriaId }, "grado_id").IsUnique();

            entity.HasIndex(e => e.MateriaId, "materia_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.GradoId)
                .HasColumnType("int(11)")
                .HasColumnName("grado_id");
            entity.Property(e => e.MateriaId)
                .HasColumnType("int(11)")
                .HasColumnName("materia_id");

            entity.HasOne(d => d.Grado).WithMany(p => p.Gradomateria)
                .HasForeignKey(d => d.GradoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gradomateria_ibfk_1");

            entity.HasOne(d => d.Materia).WithMany(p => p.Gradomateria)
                .HasForeignKey(d => d.MateriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gradomateria_ibfk_2");
        });

        modelBuilder.Entity<Materium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("materia");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Matriculafinanza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("matriculafinanzas");

            entity.HasIndex(e => e.UsuarioId, "usuario_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.FechaPago).HasColumnName("fecha_pago");
            entity.Property(e => e.Matricula)
                .HasDefaultValueSql("'0'")
                .HasColumnName("matricula");
            entity.Property(e => e.Pension)
                .HasDefaultValueSql("'0'")
                .HasColumnName("pension");
            entity.Property(e => e.UsuarioId)
                .HasColumnType("int(11)")
                .HasColumnName("usuario_id");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Matriculafinanzas)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("matriculafinanzas_ibfk_1");
        });

        modelBuilder.Entity<Observadoralumno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("observadoralumno");

            entity.HasIndex(e => e.Docente, "docente");

            entity.HasIndex(e => e.UsuarioId, "usuario_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Docente)
                .HasColumnType("int(11)")
                .HasColumnName("docente");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioId)
                .HasColumnType("int(11)")
                .HasColumnName("usuario_id");

            entity.HasOne(d => d.DocenteNavigation).WithMany(p => p.ObservadoralumnoDocenteNavigations)
                .HasForeignKey(d => d.Docente)
                .HasConstraintName("observadoralumno_ibfk_2");

            entity.HasOne(d => d.Usuario).WithMany(p => p.ObservadoralumnoUsuarios)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("observadoralumno_ibfk_1");
        });

        modelBuilder.Entity<Parentesco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("parentesco");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Periodoacademico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("periodoacademico");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rol");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Tipoactividad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipoactividad");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Tipodocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipodocumento");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Tipodocumentoacademico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipodocumentoacademico");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Tipomaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipomaterial");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.NumeroDocumento, "numero_documento").IsUnique();

            entity.HasIndex(e => e.RolId, "rol_id");

            entity.HasIndex(e => e.TipoDocumentoId, "tipo_documento_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("apellido");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(16)
                .HasColumnName("contraseña");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(10)
                .HasColumnName("numero_documento");
            entity.Property(e => e.RolId)
                .HasColumnType("int(11)")
                .HasColumnName("rol_id");
            entity.Property(e => e.TipoDocumentoId)
                .HasColumnType("int(11)")
                .HasColumnName("tipo_documento_id");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("usuario_ibfk_2");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.TipoDocumentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("usuario_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
