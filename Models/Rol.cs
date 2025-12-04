using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Rol
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Formulario> Formularios { get; set; } = new List<Formulario>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
