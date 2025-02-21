using SaludPro.Core.Domain.Common;
using SaludPro.Core.Domain.Entities.Consultorio;

namespace SaludPro.Core.Domain.Entities.Paciente
{
    public class Pacientes : PersonaConCedulaYfoto
    {
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EsFumador { get; set; } 
        public bool Alergias { get; set; } 
        public int ConsultorioId { get; set; }
        public Consultorios Consultorio { get; set; } = null!;
    }
}
