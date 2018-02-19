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
    /// Manager de pedidos
    /// </summary>
    public class OrderManager : Manager<Order>, IOrderManager
    {
        /// <summary>
        /// constructor del maanger de pedidos
        /// </summary>
        /// <param name="context">contexto de datos</param>
        public OrderManager(IDbContext context) : base(context)
        {
        }
    }
}
