using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaOnlineMVC.MVC.Utils
{
    public class Token
    {
        /// <summary>
        /// Tiempo de expiración del token
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// Tiempo del token
        /// </summary>
        public int expires_in { get; set; }
        /// <summary>
        /// Nombre de usuario
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Roles de usuario
        /// </summary>
        public string Roles { get; set; }
    }
}