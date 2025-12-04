using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Gestionacademica
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public string? RegistrarActividades { get; set; }

    public string? GruposTrabajo { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
