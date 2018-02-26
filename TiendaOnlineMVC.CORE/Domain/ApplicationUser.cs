
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TiendaOnlineMVC.CORE.Domain
{
    /// <summary>
    /// Clase de dominio que contiene los datos de usuario
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Método para crear un usuario asincronamente
        /// </summary>
        /// <param name="manager">UserManager</param>
        /// <returns>Tarea con la identidad</returns>
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }

        /// <summary>
        /// NIF del cliente
        /// System.ComponentModel.DataAnnotation
        /// </summary>
        [MaxLength(10)]
        [Required]
        [MinLength(7)]
        [Key]
        public string NIF { get; set; }

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