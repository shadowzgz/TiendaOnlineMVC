using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TiendaOnlineMVC.API.Helper;
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
        //Las constantes por defecto son privadas
        private const string RolAdmin = "Admin";
        private const string UserAdmin = "admin@eshop2018.es";
        private const string PwdAdmin = "123QWEasd@";


        /// <summary>
        /// Configurar el usuario Admin y roles
        /// </summary>
        public static void Configure()
        {
            //Configuramos seguridad
            var urManager = new UserRolManager();

            //Si no existe el rol Admin , lo crea
            if (!urManager.RoleManager.RoleExists(RolAdmin))
                urManager.RoleManager.Create(new IdentityRole(RolAdmin));
           

            //Buscamos al usuario Admin, si no está lo  creamos.
            ApplicationUser user = urManager.UserManager.FindByName(UserAdmin);
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
                    IdentityResult result = urManager.UserManager.Create(user, PwdAdmin);
                    if (result.Succeeded)
                    {
                        urManager.UserManager.AddToRole(user.Id, RolAdmin);
                    }
                    else
                    {
                        throw new Exception(string.Join(",", result.Errors));
                        //TODO: Escribir en el log
                    }
                }catch (Exception ex)
                {
                    throw ex;
                }
            }else
            {
                //El usuario está creado. Comprobamos si esta en el rol admin.
                if (!urManager.UserManager.IsInRole(user.Id, RolAdmin))
                {
                    urManager.UserManager.AddToRole(user.Id, RolAdmin);
                }
            }
        }

    }
}