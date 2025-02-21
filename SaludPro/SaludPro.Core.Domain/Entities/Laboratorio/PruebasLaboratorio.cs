using SaludPro.Core.Domain.Common;
using SaludPro.Core.Domain.Entities.Consultorio;

namespace SaludPro.Core.Domain.Entities.Laboratorio
{
    public class PruebasLaboratorio : BaseEntity
    {
        
        public string NombrePrueba { get; set; } 
        public int ConsultorioId { get; set; }
        public Consultorios Consultorio { get; set; } = null!;

    }
}
