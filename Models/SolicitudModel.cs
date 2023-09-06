using System.ComponentModel.DataAnnotations;

namespace UmbracoProject1.Models
{
    public class SolicitudModel
    {

        [Required(ErrorMessage = "Ingrese su nombre")]
        [MaxLength(100, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese su apellido")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese su apellido")]
        [MaxLength(100, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Apellido { get; set; }


        [Required(ErrorMessage = "Ingrese la empresa")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese la empresa")]
        [MaxLength(100, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Ingrese su cargo")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese su cargo")]
        [MaxLength(100, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Cargo { get; set; }


        [Display(Name = "Correo", Description = "Correo")]
        [Required(ErrorMessage = "Ingrese su correo electrónico")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese su correo electrónico")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Ingrese su número de teléfono")]
        [MaxLength(15, ErrorMessage = "No debe exceder de 15 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese su mensaje")]
        [DataType(DataType.MultilineText, ErrorMessage = "Ingrese su apellido")]
        [MaxLength(600, ErrorMessage = "No debe exceder de 600 caracteres")]
        public string Mensaje { get; set; }
        public string Origen { get; set; }
    }
}
