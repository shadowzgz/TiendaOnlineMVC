using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnlineMVC.DTOs
{
    /// <summary>
    /// DTO de producto
    /// </summary>
    public class ProductDTO
    {
        /// <summary>
        /// Identificador del producto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre dle producto
        /// </summary>
        public string Name { get; set; }
    }
}
