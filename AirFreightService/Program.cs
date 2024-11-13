
using AirFreightService;

public class Program
{
    static void Main(string[] args)
    {
        IFlightLoader fixedFlightLoader = new FixedFlightLoader();
        IOrdersLoader jsonOrdersLoader = new JsonOrdersLoader("coding-assigment-orders.json");

        AirFreightSerice airFreightSerice = new AirFreightSerice(fixedFlightLoader, jsonOrdersLoader);
        // Load flight schedule
        List<Flight> flightSchedule = airFreightSerice.LoadFlightSchedule();
        // Print schedule to console
        airFreightSerice.ListOutFlightScheduleOnConsole();

        //Generate flight itineraries
        List<string> itineraries = airFreightSerice.GenerateFlightItineraries();
        // Print itineraries to console
        airFreightSerice.ListOutItinerariesOnConsole(itineraries);
    }

}