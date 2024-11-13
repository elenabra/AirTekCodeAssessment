

namespace AirFreightService
{
    /// <summary>
    /// This service provides air freight functions:
    /// - Loading flight schedule
    /// - Listing out most recently loaded flight schedule on the console
    /// - Generating flight itineraries by scheduling a batch of orders.
    /// </summary>
    public class AirFreightSerice
    {
        /// <summary>
        /// Flight schedule loader
        /// </summary>
        private IFlightLoader _flightLoader;
        /// <summary>
        /// Orders loader
        /// </summary>
        private IOrdersLoader _ordersLoader;

        /// <summary>
        /// The most recent flight schedule 
        /// </summary>
        private List<Flight> _flightSchedule = new List<Flight>();

        /// <summary>
        /// C'tor receives a specific loaders classes 
        /// </summary>
        /// <param name="flightLoader"></param>
        public AirFreightSerice(IFlightLoader flightLoader, IOrdersLoader ordersLoader)
        {
            _flightLoader = flightLoader;
            _ordersLoader = ordersLoader;
        }

        /// <summary>
        /// Loads a flight schedule 
        /// </summary>
        /// <returns></returns>
        public List<Flight> LoadFlightSchedule()
        {
            try
            {
                _flightSchedule = _flightLoader.LoadFlightSchedule();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load flight schedule: {ex.Message}");
            }

            return _flightSchedule;
        }


        /// <summary>
        /// Schedules a batch of orders to appropriate flights
        /// </summary>
        /// <returns></returns>
        public List<string> GenerateFlightItineraries()
        {
            List<string> itineraries = new List<string>();

            try
            {
                // Load flight schedule
                LoadFlightSchedule();
                // Load orders
                Dictionary<string,Order> orders = LoadOrders();

                // Find flight for each order
                foreach (var (orderId, order) in orders)
                {
                    var flight = _flightSchedule.FirstOrDefault(f => f.Destination == order.destination && f.BoxesOnBoard < f.Capacity);
                    if (flight != null)
                    {
                        //Fount flight for order, increment num of boxes on board
                        ++flight.BoxesOnBoard;
                        itineraries.Add($"order: {orderId}, flightNumber: {flight.Id}, departure: {flight.Departure}, arrival: {flight.Destination}, day: {flight.Day}");
                    }
                    else
                    {
                        // Did not find flight for order
                        itineraries.Add($"order: {orderId}, flightNumber: not scheduled");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Failed to generate flight itineraries: {ex.Message}");
            }
            return itineraries;
        }

        /// <summary>
        /// Print flights schedule to console
        /// </summary>
        public void ListOutFlightScheduleOnConsole()
        {
            try
            {
                Console.WriteLine("Flight Schedule:");

                foreach (Flight flight in _flightSchedule)
                {
                    Console.WriteLine(flight.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to list out flight schedule on consol: {ex.Message}");
            }
        }

        /// <summary>
        /// Print itineraries on console
        /// </summary>
        /// <param name="itineraries"></param>
        public void ListOutItinerariesOnConsole(List<string> itineraries)
        {
            try
            {
                Console.WriteLine("Scheduled Itineraries:");

                foreach (string itinerary in itineraries)
                {
                    Console.WriteLine(itinerary);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to list out itineraries on consol: {ex.Message}");
            }
        }


        /// <summary>
        /// Load orders 
        /// </summary>
        /// <returns></returns>
        private Dictionary<string,Order> LoadOrders()
        {
            Dictionary<string,Order> orders;

            try
            {
                orders = _ordersLoader.LoadOrders();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load flight schedule: {ex.Message}");
                //return empty list of orders
                orders = new Dictionary<string,Order>();
            }

            return orders;
        }
    }
}
