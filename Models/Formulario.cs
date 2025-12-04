using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Formulario
{
    public int Id { get; set; }

    public int TipoDocumentoId { get; set; }

    public int NumeroDocumento { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int RolId { get; set; }

    public virtual Rol Rol { get; set; } = null!;

    public virtual Tipodocumento TipoDocumento { get; set; } = null!;
}
