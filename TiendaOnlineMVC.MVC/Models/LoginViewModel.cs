using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TiendaOnlineMVC.MVC.Models
{
    public class LoginViewModel
    {
        /// <summary>
        /// Correo del usuario
        /// </summary>
        [Required]
        [Display(Name = "Correo electrónico")]
        [EmailAddress]
        public string UserName { get; set; }
        
        /// <summary>
        /// Contraseña del usuario
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}