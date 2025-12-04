using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Documentacion
{
    public int Id { get; set; }

    public int? TipoDocumentoId { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? UsuarioId { get; set; }

    public virtual Tipodocumentoacademico? TipoDocumento { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
