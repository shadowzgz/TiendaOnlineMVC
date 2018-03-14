using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TiendaOnlineMVC.CORE.Interfaces;
using TiendaOnlineMVC.DTOs;

namespace TiendaOnlineMVC.MVC.Controllers
{
    /// <summary>
    /// Controlador de productos
    /// </summary>
    public class ProductController : ApiController
    {
        IProductManager productManager;

        public ProductController(IProductManager productManager)
        {
            this.productManager = productManager;
        }

        /// <summary>
        /// Obtener todos los productos
        /// </summary>
        /// <returns>Lista de productos</returns>
        /// Api/Products/Products
        [HttpGet]
        public ICollection<ProductDTO> Products()
        {
            return productManager.GetAll().ProjectTo<ProductDTO>().ToList();
        }
    }
}
