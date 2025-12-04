using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Materium
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Gradomaterium> Gradomateria { get; set; } = new List<Gradomaterium>();
}
