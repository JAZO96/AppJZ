using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Tipoactividad
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Actividadevaluacion> Actividadevaluacions { get; set; } = new List<Actividadevaluacion>();
}
