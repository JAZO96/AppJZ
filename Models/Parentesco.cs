using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Parentesco
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Datosadicionale> Datosadicionales { get; set; } = new List<Datosadicionale>();
}
