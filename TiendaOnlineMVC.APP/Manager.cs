using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnlineMVC.CORE.Interfaces;

namespace TiendaOnlineMVC.APP
{
    /// <summary>
    /// Clase genérica de servicios de aplicación
    /// </summary>
    public class Manager<T> : IManager<T>
        where T : class
    {
        /// <summary>
        /// Contexto de datos
        /// </summary>
        public IDbContext Context { get; private set; }

        /// <summary>
        /// Contructor de la clase
        /// 
        /// </summary>
        /// <param name="context"></param>
        public Manager(IDbContext context)
        {
            Context = context;
        }

        /// <inheritdoc/>
        public T GetById(object id)
        {
            return Context.Set<T>().Find(id);
        }

        /// <inheritdoc/>
        public IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }
    }
}
