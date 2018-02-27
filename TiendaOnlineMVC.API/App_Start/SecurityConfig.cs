using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TiendaOnlineMVC.CORE.Domain;
using TiendaOnlineMVC.CORE.Interfaces;
using TiendaOnlineMVC.IFR.Helpers;

namespace TiendaOnlineMVC.API
{

    
    /// <summary>
    /// Clase de configuración de seguridad (usuarios y roles iniciales)
    /// </summary>
    public static class SecurityConfig
    {
        private const string UserAdmin = "admin@eshop2018.es";
        private const string PwdAdmin = "123QWEasd@";


        /// <summary>
        /// Configurar el usuario Admin y roles
        /// </summary>
        public static void Configure()
        {
            //Instanciar context de datos y UserManager
            var context = IoCHelper.Resolve<IDbContext>();
            UserManager<ApplicationUser> UserManager = 
                new UserManager<ApplicationUser>(new UserStore<ApplicationUser>((DbContext)context));

            ApplicationUser user = UserManager.FindByName(UserAdmin);
            if (user == null)
            {
                user = new ApplicationUser()
                {
                    UserName = UserAdmin,
                    NIF = "100000S",
                    Name = "Super",
                    Surnames = "Admin"
                };
                try
                {
                    IdentityResult result = UserManager.Create(user, PwdAdmin);
                    if (!result.Succeeded)
                    {
                        throw new Exception(string.Join(",", result.Errors));
                    }
                }catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}