using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnlineMVC.CORE.Domain;

namespace TiendaOnlineMVC.CORE.Interfaces
{
    /// <summary>
    /// Interfaz de manager de pedidos
    /// </summary>
    public interface IShoppingCartManager : IManager<ShoppingCartLine>
    {
    }
}
