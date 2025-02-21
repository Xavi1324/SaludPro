using SaludPro.Core.Domain.Common;
using SaludPro.Core.Domain.Entities.Cita;

namespace SaludPro.Core.Domain.Entities.Laboratorio
{
    public class ResultadosLaboratorio : BaseEntity
    {
        
        public int CitaId { get; set; }
        public Citas Cita { get; set; } = null!;
        public int PruebaId { get; set; }
        public PruebasLaboratorio Prueba { get; set; } = null!;
        public string Resultado { get; set; }
        public EstadoResultado Estado { get; set; } = EstadoResultado.Pendiente;
    }

    public enum EstadoResultado
    {
        Pendiente,
        Completado
    }

}
