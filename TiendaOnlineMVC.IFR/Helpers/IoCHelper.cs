using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace TiendaOnlineMVC.IFR.Helpers
{
    /// <summary>
    /// Helper de IoC
    /// </summary>
    public static class IoCHelper
    {
        /// <summary>
        /// Resolver un tipo
        /// </summary>
        /// <typeparam name="T">Tipo a resolver</typeparam>
        /// <returns>Objeto resuelto</returns>
        public static object Resolve<T>()
        {
            return IoC.UnityConfig.Container.Resolve<T>();
        }





    }
}
