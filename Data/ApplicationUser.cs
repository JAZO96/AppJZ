using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppJZ.Data
{
    [Table("usuario")]
    public class ApplicationUser : IdentityUser
    {
        [Column("id")]
        public override string Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("apellido")]
        public string Apellido { get; set; }

        [Column("email")]
        public override string Email { get; set; }

        [Column("numero_documento")]
        public string NumeroDocumento { get; set; }

        [Column("rol_id")]
        public int RolId { get; set; }

        [Column("tipo_documento_id")]
        public int TipoDocumentoId { get; set; }

        // Este campo existe en tu BD, pero Identity no lo usa
        [Column("contraseña")]
        public string ClaveAntigua { get; set; }
    }
}
