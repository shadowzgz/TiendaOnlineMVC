using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TiendaOnlineMVC.CORE.Domain;

namespace TiendaOnlineMVC.CORE.Interfaces
{
    /// <summary>
    /// Interfaz del contexto de datos
    /// </summary>
    public interface IDbContext
    {
        /// <summary>
        /// Colección persistible de categorías
        /// </summary>
        DbSet<Category> Categories { get; set; }
        /// <summary>
        /// colección persistible de pedidos
        /// </summary>
        DbSet<Order> Orders { get; set; }
        /// <summary>
        /// Colección persistible de productos
        /// </summary>
        DbSet<Product> Products { get; set; }
        /// <summary>
        /// Colección persistible del carrito
        /// </summary>
        DbSet<ShoppingCartLine> ShoppingCart { get; set; }
        /// <summary>
        /// Colección persistible de impuestos
        /// </summary>
        DbSet<Tax> Taxes { get; set; }

        /// <summary>
        /// Método para guardar cambios
        /// </summary>
        /// <returns>Registros afectados</returns>
        int SaveChanges();

        /// <summary>
        /// Obtiene la colección de una entidad
        /// </summary>Entidad de la que queremos el contexto
        /// <typeparam name="T"></typeparam>
        /// <returns>Colección de la entidad</returns>
        DbSet<T> Set<T>() where T : class;

        /// <summary>
        /// Obtiene una entrada de una entidad del contexto
        /// </summary>
        /// <typeparam name="T">Tipo de entidad de la que queremos la entrada</typeparam>
        /// <param name="entity">entidad de la que uqeremos su entrada </param>
        /// <returns>Entada de la entidad</returns>
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
    }
}