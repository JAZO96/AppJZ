using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Bibliotecaalmacen
{
    public int Id { get; set; }

    public int? TipoMaterialId { get; set; }

    public string? NombreMaterial { get; set; }

    public bool? Disponible { get; set; }

    public int? Cantidad { get; set; }

    public virtual Tipomaterial? TipoMaterial { get; set; }
}
