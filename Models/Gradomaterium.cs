using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Gradomaterium
{
    public int Id { get; set; }

    public int GradoId { get; set; }

    public int MateriaId { get; set; }

    public virtual Grado Grado { get; set; } = null!;

    public virtual Materium Materia { get; set; } = null!;
}
