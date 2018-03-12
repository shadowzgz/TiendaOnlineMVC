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

namespace TiendaOnlineMVC.API.Helper
{
    public class UserRolManager
    {

        public UserManager<ApplicationUser> UserManager { get; private set; }
        /// <summary>
        /// Manager de roles
        /// </summary>
        public RoleManager<IdentityRole> RoleManager { get; private set; }
        /// <summary>
        /// Contexto de datos
        /// </summary>
        public IDbContext Context { get; set; }

        /// <summary>
        /// Constructr de la clase
        /// </summary>
        /// <param name="context"></param>
        public UserRolManager(IDbContext context=null)
        {
            if (context != null)
                Context = context;
            else
                Context =  IoCHelper.Resolve<IDbContext>();
            
            RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>((DbContext)Context));
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>((DbContext)Context));
        }










    }
}