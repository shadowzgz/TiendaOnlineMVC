using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaOnlineMVC.MVC.Security
{
    public interface IUserSession
    {
        /// <summary>
        /// Nombre de usuario
        /// </summary>
        string Username { get; }
        /// <summary>
        /// Token
        /// </summary>
        string BearerToken { get; }
        /// <summary>
        /// Roles
        /// </summary>
        List<string> Roles { get; }
    }

}