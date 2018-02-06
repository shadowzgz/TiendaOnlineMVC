using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaOnlineMVC.CORE.Domain
{
    /// <summary>
    /// Clase de dominio de categorías
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de categoría
        /// </summary>
        public string Name { get; set; }

        #region Parent
        /// <summary>
        /// Identificador de categoría padre
        /// </summary>
        [ForeignKey("Parent")]
        public int ParentId { get; set; }

        /// <summary>
        /// Objeto de categoría padre
        /// </summary>
        public Category Parent { get; set; }
        #endregion
        
        /// <summary>
        /// Colección de productos que tiene la categoría
        /// </summary>
        public List<Product> Products { get; set; }

    }
}