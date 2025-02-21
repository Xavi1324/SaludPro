using SaludPro.Core.Domain.Common;
using SaludPro.Core.Domain.Entities.Consultorio;

namespace SaludPro.Core.Domain.Entities.Medico
{
    public class Medicos : PersonaConCedulaYfoto
    {
        public int ConsultorioId { get; set; } 
        public Consultorios Consultorio { get; set; } = null!;
    }
}
