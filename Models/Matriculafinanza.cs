using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Matriculafinanza
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public bool? Matricula { get; set; }

    public bool? Pension { get; set; }

    public DateOnly? FechaPago { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
