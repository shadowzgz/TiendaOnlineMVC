using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnlineMVC.CORE.Domain
{
    /// <summary>
    /// Clase de dominio de productos
    /// </summary>
    public class Product
    {   
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Descripción breve
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Precio
        /// </summary>
        public decimal Price { get; set; }
        
        /// <summary>
        /// Stock del producto
        /// </summary>
        public decimal Stock { get; set; }

        /// <summary>
        /// Está disponible el producto
        /// </summary>
        public bool Available { get; set; }

        /// <summary>
        /// Impuesto asociado
        /// </summary>
        public Tax tax { get; set; }

        /// <summary>
        /// Categorías del producto
        /// </summary>
        public List<Category> Categories { get; set; }

        /// <summary>
        /// Listado de los documentos del producto
        /// </summary>
        public List<Document> Documents { get; set; }

    }
}
