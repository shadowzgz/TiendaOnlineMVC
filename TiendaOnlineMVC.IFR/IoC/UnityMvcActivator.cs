using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

using Unity.AspNet.Mvc;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TiendaOnlineMVC.IFR.IoC.UnityMvcActivator), nameof(TiendaOnlineMVC.IFR.IoC.UnityMvcActivator.Start))]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(TiendaOnlineMVC.IFR.IoC.UnityMvcActivator), nameof(TiendaOnlineMVC.IFR.IoC.UnityMvcActivator.Shutdown))]

namespace TiendaOnlineMVC.IFR.IoC
{
    /// <summary>
    /// Provides the bootstrapping for integrating Unity with ASP.NET MVC. Preparamos la clase tanto para MVC como para API
    /// </summary>
    public static class UnityMvcActivator
    {
        /// <summary>
        /// Integrates Unity when the application starts.
        /// </summary>
        public static void Start() 
        {
            FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
            FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(UnityConfig.Container));

            DependencyResolver.SetResolver(new UnityDependencyResolver(UnityConfig.Container));

            //Añadimos esto para el API Añadimos un dependenci resolver que va a pertenecer al webapi
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.AspNet.WebApi.UnityDependencyResolver(UnityConfig.Container); ;

            // TODO: Uncomment if you want to use PerRequestLifetimeManager
            // Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(UnityPerRequestHttpModule));
        }

        /// <summary>
        /// Disposes the Unity container when the application is shut down.
        /// </summary>
        public static void Shutdown()
        {
            UnityConfig.Container.Dispose();
        }
    }
}