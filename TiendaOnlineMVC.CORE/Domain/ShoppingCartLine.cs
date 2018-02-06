using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnlineMVC.CORE.Domain
{
    /// <summary>
    /// entidad de cdominio de carrito de la compra
    /// </summary>
    public class ShoppingCartLine
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
        /// Sesión de usuario (Identificación de usuario temporal)
        /// </summary>
        public string Session { get; set; }

        /// <summary>
        /// Fecha de insercción
        /// </summary>
        public DateTime Date { get; set; }

        #region Relación del producto
        /// <summary>
        /// Identificador del producto
        /// </summary>
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        /// <summary>
        /// Objeto del producto
        /// </summary>
        public Product Product { get; set; }
        #endregion

        /// <summary>
        /// Cantidad añadida
        /// </summary>
        public decimal Quantity { get; set; }
    }
}
