using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnlineMVC.CORE.Domain;

namespace TiendaOnlineMVC.CORE.Interfaces
{
    public interface IProductManager : IManager<Product>
    {
        /// <summary>
        /// Obtiene los productos de una categoría
        /// </summary>
        /// <param name="categoryId">Identificador de categoría</param>
        /// <returns>Productos de categoría indicada</returns>
        IQueryable<Product> GetByCategoryId(int categoryId);



    }
}
