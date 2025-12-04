using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Tipomaterial
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Bibliotecaalmacen> Bibliotecaalmacens { get; set; } = new List<Bibliotecaalmacen>();
}
