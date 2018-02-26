using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TiendaOnlineMVC.API.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {   
        /// <summary>
        /// Obtener todos los valores
        /// </summary>
        /// <returns>Todos los valores</returns>
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Obtener un valor por su id
        /// </summary>
        /// <param name="id">identificador del valor que blablablabla</param>
        /// <returns></returns>
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
