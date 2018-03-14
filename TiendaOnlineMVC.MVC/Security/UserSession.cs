using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace TiendaOnlineMVC.MVC.Security
{
    public class UserSession : IUserSession
    {
        /// <inheritdoc/>
        public string Username
        {
            get { return ((ClaimsPrincipal)HttpContext.Current.User).FindFirst(ClaimTypes.Name).Value; }
        }

        /// <inheritdoc/>
        public string BearerToken
        {
            get {return ((ClaimsPrincipal)HttpContext.Current.User).FindFirst("AcessToken").Value; }
        }

        /// <inheritdoc/>
        public List<string> Roles
        {
            get
            {
                return ((ClaimsPrincipal)HttpContext.Current.User)
                    .FindAll(ClaimTypes.Role).Select(e => e.Value).ToList();
            }
        }
    }
}