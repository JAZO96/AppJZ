using AppJZ.Data;
using System;
using System.Collections.Generic;

namespace AppJZ.Models;

public partial class Documentacion
{
    public int Id { get; set; }

    public int? TipoDocumentoId { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? UsuarioId { get; set; }
    public ApplicationUser? Usuario { get; set; }

    public virtual Tipodocumentoacademico? TipoDocumento { get; set; }

}
