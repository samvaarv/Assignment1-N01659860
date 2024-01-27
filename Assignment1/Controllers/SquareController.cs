using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Calculate and returns the square of a given number
        /// </summary>
        /// <param name="id">The number for which the square needs to be calculated.</param>
        /// <returns>The square of the input number.</returns>
        /// <example>
        ///     GET : localhost:xx/api/Square/2 => 4
        /// </example>
        /// <example>
        ///     GET : localhost:xx/api/Square/-2 => 4
        /// </example>
        /// <example>
        ///     GET : localhost:xx/api/Square/10 => 100
        /// </example>
        public int Get(int id)
        {
            return id * id;
        }

    }
}
