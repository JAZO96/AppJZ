using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Tipodocumentoacademico
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Documentacion> Documentacions { get; set; } = new List<Documentacion>();
}
