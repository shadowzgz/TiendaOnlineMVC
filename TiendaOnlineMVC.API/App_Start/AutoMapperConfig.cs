using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaOnlineMVC.CORE.Domain;
using TiendaOnlineMVC.DTOs;

namespace TiendaOnlineMVC.API
{
    /// <summary>
    /// Configurador de Automaper
    /// </summary>
    public class AutoMapperConfig
    {
        /// <summary>
        /// Método para configurar el AutoMapper
        /// </summary>
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductDTO>());
        }




    }
}