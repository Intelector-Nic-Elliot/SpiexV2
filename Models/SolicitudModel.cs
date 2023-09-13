using System.ComponentModel.DataAnnotations;

namespace UmbracoProject1.Models
{
    public class SolicitudModel
    {
        [Display(Name = "Nombre", Description ="Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese su nombre")]
        [MaxLength(100, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido", Description = "Apellido")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese su apellido")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese su apellido")]
        [MaxLength(100, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Apellido { get; set; }

        [Display(Name = "Empresa", Description ="Empresa")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese la empresa")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese la empresa")]
        [MaxLength(100, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Empresa { get; set; }

        [Display(Name = "Cargo", Description = "Cargo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese su cargo")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese su cargo")]
        [MaxLength(100, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Cargo { get; set; }


        [Display(Name = "Correo", Description = "Correo")]
        [Required(ErrorMessage = "Ingrese su correo electrónico")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese un correo electrónico")]
        public string Correo { get; set; }

        [Display(Name = "Telefono", Description = "Telefono")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese su número de teléfono")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Ingrese un numero de telefono")]
        [MaxLength(20, ErrorMessage = "Ingrese su numero")]
        public string Telefono { get; set; }

        [Display(Name = "Mensaje", Description = "Mensaje")]
        [Required(ErrorMessage = "Ingrese su mensaje")]
        [DataType(DataType.MultilineText, ErrorMessage = "Ingrese un mensaje")]
        [MaxLength(600, ErrorMessage = "No debe exceder de 600 caracteres")]
        public string Mensaje { get; set; }
        public string Origen { get; set; }
    }
}
