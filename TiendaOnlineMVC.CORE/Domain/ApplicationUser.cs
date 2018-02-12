
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaOnlineMVC.CORE.Domain
{
    /// <summary>
    /// Clase de dominio que contiene los datos de usuario
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// NIF del cliente
        /// System.ComponentModel.DataAnnotation
        /// </summary>
        [MaxLength(10)]
        [Required]
        [MinLength(7)]
        [Key]
        public int NIF { get; set; }

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Apellidos del usuario
        /// </summary>
        [Required]
        public string Surnames { get; set; }

        /// <summary>
        /// Listado de direcciones
        /// </summary>
        public List<Address> Addresses { get; set; }

    }
}