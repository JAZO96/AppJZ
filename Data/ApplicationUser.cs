using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppJZ.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Column("apellido")]
        [StringLength(50)]
        public string Apellido { get; set; } = string.Empty;

        [Column("numero_documento")]
        [StringLength(10)]
        public string NumeroDocumento { get; set; } = string.Empty;

        [Column("rol_id")]
        public int? RolId { get; set; }

        [Column("tipo_documento_id")]
        public int? TipoDocumentoId { get; set; }

        [Column("imagen")]
        public string? Imagen { get; set; }

        [Column("estado")]
        public bool Estado { get; set; } = true;

        [Column("fecha_registro")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("RolId")]
        public virtual AppJZ.Models.Rol? Rol { get; set; }

        [ForeignKey("TipoDocumentoId")]
        public virtual AppJZ.Models.Tipodocumento? TipoDocumento { get; set; }

        // Navegaciones
        [InverseProperty("Usuario")]
        public virtual ICollection<AppJZ.Models.Actividadevaluacion> Actividadevaluacions { get; set; }
            = new List<AppJZ.Models.Actividadevaluacion>();

        [InverseProperty("Usuario")]
        public virtual ICollection<AppJZ.Models.Documentacion> Documentacions { get; set; }
            = new List<AppJZ.Models.Documentacion>();

        [InverseProperty("Usuario")]
        public virtual ICollection<AppJZ.Models.Matriculafinanza> Matriculafinanzas { get; set; }
            = new List<AppJZ.Models.Matriculafinanza>();

        [InverseProperty("Usuario")]
        public virtual ICollection<AppJZ.Models.Gestionacademica> Gestionacademicas { get; set; }
            = new List<AppJZ.Models.Gestionacademica>();

        [InverseProperty("Usuario")]
        public virtual ICollection<AppJZ.Models.Observadoralumno> ObservadoralumnoUsuarios { get; set; }
            = new List<AppJZ.Models.Observadoralumno>();

        [InverseProperty("Estudiante")]
        public virtual ICollection<AppJZ.Models.Administracionescolar> AdministracionescolarEstudiantes { get; set; }
            = new List<AppJZ.Models.Administracionescolar>();

        [InverseProperty("Docente")]
        public virtual ICollection<AppJZ.Models.Administracionescolar> AdministracionescolarDocentes { get; set; }
            = new List<AppJZ.Models.Administracionescolar>();

        [NotMapped]
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
