using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Generates a greeting message based on the number of people specified in the GET request.
        /// </summary>
        /// <param name="id">The number of people for whom the greeting message is intended.</param>
        /// <returns>A greeting message including the specified number of people.</returns>
        /// <example>
        ///     GET : localhost:xx/api/Greeting/3 => "Greetig to 3 people!"
        /// </example>
        /// <example>
        ///     GET : localhost:xx/api/Greeting/6 => "Greetig to 6 people!"
        /// </example>
        /// <example>
        ///     GET : localhost:xx/api/Greeting/0 => "Greetig to 0 people!"
        /// </example>
        public string Get(int id)
        {
            return "Greeting to " + id + " people!";
        }

        /// <summary>
        /// Generates a default greeting message for a POST request.
        /// </summary>
        /// <returns>The default greeting message "Hello World!" for a POST request.</returns>
        /// <example>
        ///     POST : localhost:xx/api/Greeting => "Hello World!"
        /// </example>
        public string Post()
        {
            return "Hello World!";
        }
    }
}
