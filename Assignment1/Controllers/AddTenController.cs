using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds ten to a given number and returns the result.
        /// </summary>
        /// <param name="id">The number to which ten needs to be added.</param>
        /// <returns>The result of adding ten to the input number.</returns>
        /// <example>
        ///     GET : localhost:xx/api/AddTen/21 => 31
        /// </example>
        /// <example>
        ///     GET : localhost:xx/api/AddTen/0 => 10
        /// </example>
        /// <example>
        ///     GET : localhost:xx/api/AddTen/-9 => 1
        /// </example>
        public int Get(int id)
        {
            return id + 10;
        }

    }
}
