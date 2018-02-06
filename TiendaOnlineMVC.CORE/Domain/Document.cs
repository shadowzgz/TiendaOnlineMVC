using System.ComponentModel.DataAnnotations.Schema;
using TiendaOnlineMVC.CORE.Enums;

namespace TiendaOnlineMVC.CORE.Domain
{
    /// <summary>
    /// Clase de dominio de documentos
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ruta del documento
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Tipo de documento
        /// </summary>
        public DocumentType Type { get; set; }

        /// <summary>
        /// Orden de visualización del documento
        /// </summary>
        public int Oder { get; set; }

#region relacion con el producto
        /// <summary>
        /// Identificador del producto
        /// </summary>
        
        [ForeignKey("Product")]
        public int ProdcutId { get; set; }

        /// <summary>
        /// Objeto del producot relacionado
        /// </summary>
        public Product Product { get; set; }
#endregion
    }
}