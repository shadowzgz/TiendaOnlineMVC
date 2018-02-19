using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnlineMVC.CORE.Domain;
using TiendaOnlineMVC.CORE.Interfaces;

namespace TiendaOnlineMVC.APP
{
    /// <summary>
    /// Manager de categorías
    /// </summary>
    public class CategoryManager : Manager<Category>, ICategoryManager
    {
        /// <summary>
        /// Constructor del manager
        /// </summary>
        /// <param name="context"C>Contexto de datos</param>
        public CategoryManager(IDbContext context) : base(context)
        {
        }
    }
}
