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
    /// Manager de producto
    /// </summary>
    public class ProductManager : Manager<Product>, IProductManager
        {

        public ProductManager(IDbContext context) : base(context)
        {
        
        }

        /// <inheritdoc/>
        public IQueryable<Product> GetByCategoryId(int categoryId)
        {
            return Context.Products.Where(e => e.Categories.Where(c => c.Id == categoryId).Any());
        }
    }
}
