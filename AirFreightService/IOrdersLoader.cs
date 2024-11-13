using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFreightService
{
    /// <summary>
    /// Interface for loading orders. Inheriting class can implement loading orders from DB, file, etc.
    /// </summary>
    public interface IOrdersLoader
    {
        /// <summary>
        /// Load orders
        /// </summary>
        /// <returns></returns>
        Dictionary<string, Order> LoadOrders();
    }
}
