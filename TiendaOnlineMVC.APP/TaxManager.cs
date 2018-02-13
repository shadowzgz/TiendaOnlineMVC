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
    /// Manager de tasas
    /// </summary>
    public class TaxManager : Manager<Tax>, ITaxManager
    {
        /// <summary>
        /// Constructor del manager
        /// </summary>
        /// <param name="context"></param>
        public TaxManager(IDbContext context) : base(context)
        {
        }
    }
}
