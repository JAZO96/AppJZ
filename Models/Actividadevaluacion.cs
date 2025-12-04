using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Actividadevaluacion
{
    public int Id { get; set; }

    public int? TipoActividadId { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? UsuarioId { get; set; }

    public virtual Tipoactividad? TipoActividad { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
