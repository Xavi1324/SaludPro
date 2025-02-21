using SaludPro.Core.Domain.Common;
using SaludPro.Core.Domain.Entities.Consultorio;

namespace SaludPro.Core.Domain.Entities.Usuario
{
    public class Usuarios : PersonaBase
    {
        
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public TipoUsuario Tipo { get; set; }
        public int ConsultorioId { get; set; }
        public Consultorios Consultorio { get; set; } = null!;
    }

    public enum TipoUsuario
    {
        Administrador,
        Asistente
    }


}
