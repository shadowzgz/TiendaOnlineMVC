using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnlineMVC.CORE.Interfaces
{
    /// <summary>
    /// Interfaz del manager genérico
    /// </summary>
    public interface IManager<T>
    {
        /// <summary>
        /// Obtener un elemento por su id
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>Objeto con el id indicado</returns>
        T GetById(object id);

        /// <summary>
        /// Obtener todos los registros
        /// </summary>
        /// <returns>Lista de todos los registros</returns>
        IQueryable<T> GetAll();



    }
}
