using AppJZ.Data;

namespace AppJZ.Models
{
    public partial class Administracionescolar
    {
        public int Id { get; set; }

        // ----------------------------
        // DOCENTE (IdentityUser)
        // ----------------------------
        public string? DocenteId { get; set; }
        public ApplicationUser? Docente { get; set; }

        // ----------------------------
        // ESTUDIANTE (IdentityUser)
        // ----------------------------
        public string? EstudianteId { get; set; }
        public ApplicationUser? Estudiante { get; set; }

        // ----------------------------
        // GRADO
        // ----------------------------
        public int? GradoId { get; set; }
        public Grado? Grado { get; set; }
    }
}
