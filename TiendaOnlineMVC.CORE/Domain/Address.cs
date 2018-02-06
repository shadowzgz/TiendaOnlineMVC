using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaOnlineMVC.CORE.Domain
{
    /// <summary>
    /// Entidad de dominio de dirección
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        #region Relacion con el usuario
        /// <summary>
        /// Identificador de usuario
        /// </summary>
        [ForeignKey("User")]
        public string UserId { get; set; }

        /// <summary>
        /// Objeto de usuario
        /// </summary>
        public ApplicationUser User { get; set; }
        #endregion

        /// <summary>
        /// Texto de dirección 1
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// Texto de dirección 2
        /// </summary>
        public string Address2 { get; set; }
        /// <summary>
        /// Código postal
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// ciudad
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Provincia
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// País
        /// </summary>
        public string Country { get; set; }

    }
}