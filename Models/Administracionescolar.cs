using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Administracionescolar
{
    public int Id { get; set; }

    public int? DocenteId { get; set; }

    public int? GradoId { get; set; }

    public int? EstudianteId { get; set; }

    public virtual Usuario? Docente { get; set; }

    public virtual Usuario? Estudiante { get; set; }

    public virtual Grado? Grado { get; set; }
}
