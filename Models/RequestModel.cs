using System.ComponentModel.DataAnnotations;

namespace UmbracoProject1.Models
{
    public class RequestModel
    {

        [Required(ErrorMessage = "Ingrese su nombre")]
        [MaxLength(200, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Names { get; set; }

        [Required(ErrorMessage = "Ingrese su apellido")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese su apellido")]
        [MaxLength(200, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Ingrese la empresa")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese la empresa")]
        [MaxLength(200, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Ingrese su cargo")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese su cargo")]
        [MaxLength(200, ErrorMessage = "No debe exceder de 100 caracteres")]
        public string Job { get; set; }


        [Display(Name = "Email", Description = "Email")]
        [Required(ErrorMessage = "Ingrese su correo electrónico")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese su correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese su número de teléfono")]
        [MaxLength(20, ErrorMessage = "No debe exceder de 15 caracteres")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Ingrese su mensaje")]
        [DataType(DataType.MultilineText, ErrorMessage = "Ingrese su mensaje")]
        [MaxLength(600, ErrorMessage = "No debe exceder de 600 caracteres")]
        public string Message { get; set; }
    }
}

