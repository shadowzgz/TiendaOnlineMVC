using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaOnlineMVC.MVC.Models.Product
{
    /// <summary>
    /// Viewmodel de producto
    /// </summary>
    public class ProductViewModel
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre
        /// </summary>
        public string Name { get; set; }
    }
}