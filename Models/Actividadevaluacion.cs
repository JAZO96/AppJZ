using AppJZ.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppJZ.Models;

public partial class Actividadevaluacion
{
    public int Id { get; set; }

    public int? TipoActividadId { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public ApplicationUser Usuario { get; set; }

    public virtual Tipoactividad? TipoActividad { get; set; }


}
