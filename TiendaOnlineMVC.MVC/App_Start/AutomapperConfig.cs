using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaOnlineMVC.DTOs;
using TiendaOnlineMVC.MVC.Models.Product;

namespace TiendaOnlineMVC.MVC
{
    /// <summary>
    /// Configurador de automaper
    /// </summary>
    public class AutomapperConfig
    {
        /// <summary>
        /// Método para configurar el automapper
        /// </summary>
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ProductDTO, ProductViewModel>());


        }

    }
}