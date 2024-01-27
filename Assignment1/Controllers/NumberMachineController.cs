using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Performs multiple operations on a given number and returns the results.
        /// </summary>
        /// <param name="id">The number for which operations need to be performed.</param>
        /// <returns>An array of strings containing results of addition, subtraction, multiplication, and division with 100.</returns>
        /// <example>
        ///     GET : localhost:xx/api/NumberMachine/10 
        ///     Response: ["Addition to 100 is 110", "Subtraction from 100 is 90", "Multiplication to 100 is 1000", "Division of 100 is 10"]
        /// </example>
        /// <example>
        ///     GET : localhost:xx/api/NumberMachine/-5 
        ///     Response: ["Addition to 100 is 95", "Subtraction from 105 is 90", "Multiplication to 100 is -500", "Division of 100 is -20"]
        /// </example>
        /// <example>
        ///     GET : localhost:xx/api/NumberMachine/30 
        ///     Response: ["Addition to 100 is 130", "Subtraction from 100 is 70", "Multiplication to 100 is 3000", "Division of 100 is 3"]
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            int add = 100 + id;
            int subtract = 100 - id;
            int multiply = 100 * id;
            int divide = 100 / id;
            return new string[] { 
                "Addition to 100 is " + add, 
                "Substraction from 100 is " + subtract, 
                "Multiplication to 100 is " + multiply, 
                "Division of 100 is " + divide };
        }

    }
}
