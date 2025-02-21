using SaludPro.Core.Domain.Common;
using SaludPro.Core.Domain.Entities.Medico;
using SaludPro.Core.Domain.Entities.Paciente;

namespace SaludPro.Core.Domain.Entities.Cita
{
    public class Citas : BaseEntity
    {
        
        public int PacienteId { get; set; }
        public Pacientes Paciente { get; set; } = null!;
        public int MedicoId { get; set; }
        public Medicos Medico { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } 
        public string Causa { get; set; } 
        public EstadoCita Estado { get; set; } = EstadoCita.Pendiente;
    }

    public enum EstadoCita
    {
        Pendiente,
        EnProceso,
        Completada,
        Cancelada
    }


}
