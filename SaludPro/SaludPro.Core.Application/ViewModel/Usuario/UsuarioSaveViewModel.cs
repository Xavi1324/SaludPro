using SaludPro.Core.Domain.Entities.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Core.Application.ViewModel.Usuario
{
    public class UsuarioSaveViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El campo Apellido es requerido")]
        [DataType(DataType.Text)]
        public string Apellido { get; set; }


        [Required(ErrorMessage = "El campo Correo es requerido")]
        [DataType(DataType.Text)]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El campo Nombre de Usuario es requerido")]
        public string NombreUsuario { get; set; }


        [Required(ErrorMessage = "El campo Contraseña es requerido")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }

        [Compare(nameof(Contraseña), ErrorMessage = "Las contraseñas deben coinciden")]
        [Required(ErrorMessage = "El campo Confirmar Contraseña es requerido")]
        [DataType(DataType.Password)]
        public string ConfirmarContraseña { get; set; }
        public TipoUsuario Tipo { get; set; }
    }
}
