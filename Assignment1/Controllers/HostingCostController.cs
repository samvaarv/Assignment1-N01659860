using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Calculates hosting costs, HST, and total cost based on the input number of days.
        /// </summary>
        /// <param name="id">The number of days for which hosting costs need to be calculated.</param>
        /// <returns>An array of strings containing detailed information about the hosting costs.</returns>
        /// <example>
        ///     GET : localhost:xx/api/HostingCost/0 
        ///     Response: 
        ///         [
        ///             “1 fortnights at $5.50/FN = $5.50 CAD”
        ///             “HST 13% = $0.72 CAD”
        ///             “Total = $6.22 CAD”
        ///         ]
        /// </example>
        /// <example>
        ///     GET : localhost:xx/api/HostingCost/14 
        ///     Response: 
        ///         [
        ///             “2 fortnights at $5.50/FN = $11.00 CAD”
        ///             “HST 13% = $1.43 CAD”
        ///             “Total = $12.43 CAD”
        ///         ]
        /// </example>
        /// <example>
        ///     GET : localhost:xx/api/HostingCost/28 
        ///     Response: 
        ///         [
        ///             “3 fortnights at $5.50/FN = $16.50 CAD”
        ///             “HST 13% = $2.15 CAD”
        ///             “Total = $18.65 CAD”
        ///         ]
        /// </example>
        public IEnumerable<string> GetHostingCost(int id)
        {
            // Constants
            decimal costPerFortnight = 5.50m;
            decimal hstRate = 0.13m;

            // Calculate the number of fortnights
            int fortnights = (id + 14) / 14; // Adding 14 to round up when necessary

            // Calculate costs
            decimal hostingCost = fortnights * costPerFortnight;
            decimal hstAmount = hostingCost * hstRate;
            decimal totalCost = hostingCost + hstAmount;

            // Display results
            return new string[] {
                $"{fortnights} fortnight(s) at ${costPerFortnight:F2}/FN = ${hostingCost:F2} CAD",
                $"HST {hstRate * 100}% = ${hstAmount:F2} CAD",
                $"Total = ${totalCost:F2} CAD\n" 
            };

        }

    }
}
