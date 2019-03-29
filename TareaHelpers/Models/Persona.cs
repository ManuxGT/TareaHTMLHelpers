using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TareaHelpers.Models
{
    public class Persona
    {

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string cedula { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string apellido { get; set; }

        [Required (ErrorMessage ="Este campo es obligatorio")]
        [Range (15,100, ErrorMessage = "Debe ser mayor de 15 años para registrarse")]
        public int edad { get; set; }

        public string telefono { get; set; }

        public string estado_civil { get; set; }

        public string correo { get; set; }

        public List<string> hobbies = new List<string>();

        public string genero { get; set; }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }







    }
}