using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Todas las clases dentro de AppStart les quitamos esto en el namespace.
/// </summary>
[assembly: OwinStartup(typeof(TiendaOnlineMVC.MVC.StartUp))]
namespace TiendaOnlineMVC.MVC
{
    public class StartUp
    {

        public void Configuration(IAppBuilder app)
        {

            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Token"),

            });


        }



    }
}