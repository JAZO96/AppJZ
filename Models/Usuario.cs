using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public int TipoDocumentoId { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public int RolId { get; set; }

    public virtual ICollection<Actividadevaluacion> Actividadevaluacions { get; set; } = new List<Actividadevaluacion>();

    public virtual ICollection<Administracionescolar> AdministracionescolarDocentes { get; set; } = new List<Administracionescolar>();

    public virtual ICollection<Administracionescolar> AdministracionescolarEstudiantes { get; set; } = new List<Administracionescolar>();

    public virtual Datosadicionale? Datosadicionale { get; set; }

    public virtual ICollection<Documentacion> Documentacions { get; set; } = new List<Documentacion>();

    public virtual ICollection<Gestionacademica> Gestionacademicas { get; set; } = new List<Gestionacademica>();

    public virtual ICollection<Matriculafinanza> Matriculafinanzas { get; set; } = new List<Matriculafinanza>();

    public virtual ICollection<Observadoralumno> ObservadoralumnoDocenteNavigations { get; set; } = new List<Observadoralumno>();

    public virtual ICollection<Observadoralumno> ObservadoralumnoUsuarios { get; set; } = new List<Observadoralumno>();

    public virtual Rol Rol { get; set; } = null!;

    public virtual Tipodocumento TipoDocumento { get; set; } = null!;
}
