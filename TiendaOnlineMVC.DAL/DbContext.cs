using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnlineMVC.CORE.Domain;

namespace TiendaOnlineMVC.DAL
{
    public class DbContext : IdentityDbContext<ApplicationUser>
    {

        /// <summary>
        /// Constructor con cadena de conexión
        /// </summary>
        /// <param name="nameOrConnectionString">Cadena de conexión</param>
        public DbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {

        }

        #region colecciones persistibles
        /// <summary>
        /// Colección persistible de Pedidos
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Colección persistible de categorías
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Colección persistible de productos
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Colección persistible del carrito
        /// </summary>
        public DbSet<ShoppingCartLine> ShoppingCart { get; set; }

        /// <summary>
        /// Colección persistible de Tasas
        /// </summary>
        public DbSet<Tax> Taxes { get; set; }
        #endregion

        /// <summary>
        /// Especificar excepciones en la creación de la base de datos
        /// </summary>
        /// <param name="modelBuilder">Constructor de la clase</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Quitar borrado en cascada entre order y direcicón de facturación
            //para evitar referencias cíclicas 
            modelBuilder.Entity<Order>().HasRequired(f => f.BillingAddress).
                WithMany().WillCascadeOnDelete(false);
            //Quitar borrado en cascada entre order y dirección de envío
            //para evitar referencias cíclicas
            modelBuilder.Entity<Order>().HasRequired(f => f.BillingAddress).
                WithMany().WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

    }
}
