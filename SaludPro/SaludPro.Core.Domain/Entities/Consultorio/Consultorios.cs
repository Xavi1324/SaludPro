using SaludPro.Core.Domain.Common;
using SaludPro.Core.Domain.Entities.Medico;
using SaludPro.Core.Domain.Entities.Usuario;

namespace SaludPro.Core.Domain.Entities.Consultorio
{
    public class Consultorios : BaseEntity
    {
        
        public string NombreConsultorio { get; set; } 
        public ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>(); 
        public ICollection<Medicos> Medicos { get; set; } = new List<Medicos>(); 
    }
}
