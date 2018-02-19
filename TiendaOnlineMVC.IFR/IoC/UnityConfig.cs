using System;
using System.Configuration;
using Unity;
using Unity.AspNet.Mvc;
using Unity.Injection;

namespace TiendaOnlineMVC.IFR.IoC
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            container.RegisterType(
                Type.GetType("TiendaOnlineMVC.CORE.Interfaces.IDbContext, TiendaOnlineMVC.CORE"),
                Type.GetType("TiendaOnlineMVC.DAL.DbContext, TiendaOnlineMVC.DAL"), 
                new PerRequestLifetimeManager(),
                new InjectionConstructor(connectionString.ToString()));
            container.RegisterType(
                Type.GetType("TiendaOnlineMVC.CORE.Interfaces.IProductManager, TiendaOnlineMVC.CORE"),
                Type.GetType("TiendaOnlineMVC.APP.ProductManager, TiendaOnlineMVC.APP"));
            container.RegisterType(
                Type.GetType("TiendaOnlineMVC.CORE.Interfaces.ICategoryManager, TiendaOnlineMVC.CORE"),
                Type.GetType("TiendaOnlineMVC.APP.CategoryManager, TiendaOnlineMVC.APP"));
            container.RegisterType(
                Type.GetType("TiendaOnlineMVC.CORE.Interfaces.IOrderManager, TiendaOnlineMVC.CORE"),
                Type.GetType("TiendaOnlineMVC.APP.OrderManager, TiendaOnlineMVC.APP"));
            container.RegisterType(
                Type.GetType("TiendaOnlineMVC.CORE.Interfaces.IShoppingCartManager, TiendaOnlineMVC.CORE"),
                Type.GetType("TiendaOnlineMVC.APP.ShoppingCartManager, TiendaOnlineMVC.APP"));
            container.RegisterType(
                Type.GetType("TiendaOnlineMVC.CORE.Interfaces.ITaxManager, TiendaOnlineMVC.CORE"),
                Type.GetType("TiendaOnlineMVC.APP.TaxManager, TiendaOnlineMVC.APP"));

        }
    }
}