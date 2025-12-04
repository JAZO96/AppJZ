using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Datosadicionale
{
    public int UsuarioId { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public int? Grado { get; set; }

    public string? NombreAcudiente { get; set; }

    public string? NumeroAcudiente { get; set; }

    public int? ParentescoId { get; set; }

    public virtual Grado? GradoNavigation { get; set; }

    public virtual Parentesco? Parentesco { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
}
