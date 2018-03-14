using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaOnlineMVC.MVC.Costants
{
    public class ApiEndPoints
    {

        /// <summary>
        /// Método para obtener el token
        /// </summary>
        public const string GetToken = "{0}/Token";

        /// <summary>
        /// Método para obtener todos los products
        /// </summary>
        public const string GetProducts = "/api/Product/Products";
    }
}