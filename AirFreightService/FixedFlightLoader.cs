namespace AirFreightService
{
    /// <summary>
    /// Fixed (pre-defigned for the exercise) schedule loader
    /// </summary>
    public class FixedFlightLoader : IFlightLoader
    {
        /// <summary>
        /// Returnes pre-defigned for the exercise schedule
        /// </summary>
        /// <returns></returns>
        public List<Flight> LoadFlightSchedule() 
        {
            List<Flight> flights = new List<Flight> ();
           
            Flight flight = new Flight();
            flight.Id = 1;
            flight.Day = 1;
            flight.Departure = "YUL";
            flight.Destination = "YYZ";
            flight.Capacity = 20;
            flight.BoxesOnBoard = 0;
            flights.Add(flight);

            flight = new Flight();
            flight.Id = 2;
            flight.Day = 1;
            flight.Departure = "YUL";
            flight.Destination = "YYC";
            flight.Capacity = 20;
            flight.BoxesOnBoard = 0;
            flights.Add(flight);

            flight = new Flight();
            flight.Id = 3;
            flight.Day = 1;
            flight.Departure = "YUL";
            flight.Destination = "YVR";
            flight.Capacity = 20;
            flight.BoxesOnBoard = 0;
            flights.Add(flight);

            flight = new Flight();
            flight.Id = 4;
            flight.Day = 2;
            flight.Departure = "YUL";
            flight.Destination = "YYZ";
            flight.Capacity = 20;
            flight.BoxesOnBoard = 0;
            flights.Add(flight);

            flight = new Flight();
            flight.Id = 5;
            flight.Day = 2;
            flight.Departure = "YUL";
            flight.Destination = "YYC";
            flight.Capacity = 20;
            flight.BoxesOnBoard = 0;
            flights.Add(flight);

            flight = new Flight();
            flight.Id = 6;
            flight.Day = 2;
            flight.Departure = "YUL";
            flight.Destination = "YVR";
            flight.Capacity = 20;
            flight.BoxesOnBoard = 0;
            flights.Add(flight);

            return flights;
        }
    }
}
