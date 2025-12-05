using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public class Grado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Codigo { get; set; }

    public int? Creditos { get; set; }

    public string? Nivel { get; set; }

    public string? Estado { get; set; }

    public int? DocenteId { get; set; }
    public virtual Docente? Docente { get; set; }

    public virtual ICollection<Administracionescolar> Administracionescolars { get; set; } = new List<Administracionescolar>();

    public virtual ICollection<Datosadicionale> Datosadicionales { get; set; } = new List<Datosadicionale>();

    public virtual ICollection<Gradomaterium> Gradomateria { get; set; } = new List<Gradomaterium>();
}
