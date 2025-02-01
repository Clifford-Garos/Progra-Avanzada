using System.ComponentModel.DataAnnotations;
namespace SM_ProyectoWeb.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "La identificación es obligatoria.")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
    }
}
