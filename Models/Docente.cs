using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppJZ.Models;

[Table("docentes")]
public partial class Docente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;
}
