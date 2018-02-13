using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnlineMVC.CORE.Domain;
using TiendaOnlineMVC.CORE.Interfaces;
using TiendaOnlineMVC.DAL;

namespace TiendaOnlineMVC.APP
{
    /// <summary>
    /// Manager de carrito
    /// </summary>
    public class ShoppingCartManager : Manager<ShoppingCartLine>, IShoppingCartManager
    {
        /// <summary>
        /// Constructor del manager
        /// </summary>
        /// <param name="context">contexto de datos</param>
        public ShoppingCartManager(IDbContext context) : base(context)
        {
        }
    }
}
