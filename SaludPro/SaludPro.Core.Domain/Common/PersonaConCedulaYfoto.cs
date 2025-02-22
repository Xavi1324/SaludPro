using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Core.Domain.Common
{
    public abstract class PersonaConCedulaYfoto :  PersonaBase
    {
        public string Cedula { get; set; }
        public string FotoUrl { get; set; }

        public string Telefono { get; set; }

    }
}
