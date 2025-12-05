using AppJZ.Data;
using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Observadoralumno
{
    public int Id { get; set; }

    public string? UsuarioId { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Observaciones { get; set; }

    public int? Docente { get; set; }

    public virtual Usuario? DocenteNavigation { get; set; }
    public ApplicationUser? Usuario { get; set; }
}
