using System;
using System.Collections.Generic;

namespace AppJZ.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }

        public int TipoDocumentoId { get; set; }
        public int RolId { get; set; }
        public string NumeroDocumento { get; set; }
        public string Imagen { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual Tipodocumento TipoDocumento { get; set; }

        public virtual ICollection<Actividadevaluacion> Actividadevaluacions { get; set; } = new List<Actividadevaluacion>();
        public virtual ICollection<Documentacion> Documentacions { get; set; } = new List<Documentacion>();
        public virtual ICollection<Matriculafinanza> Matriculafinanzas { get; set; } = new List<Matriculafinanza>();
        public virtual ICollection<Gestionacademica> Gestionacademicas { get; set; } = new List<Gestionacademica>();
        public virtual ICollection<Observadoralumno> ObservadoralumnoUsuarios { get; set; } = new List<Observadoralumno>();
        public virtual ICollection<Administracionescolar> AdministracionescolarEstudiantes { get; set; } = new List<Administracionescolar>();
    }
}
