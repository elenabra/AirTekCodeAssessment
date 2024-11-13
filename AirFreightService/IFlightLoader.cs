namespace AirFreightService
{
    /// <summary>
    /// Interface for loading flight schedule. Inheriting class can implement loading flight schedule from DB, file, etc.
    /// </summary>
    public interface IFlightLoader
    {
        /// <summary>
        /// Load flight schedule
        /// </summary>
        /// <returns></returns>
        List<Flight> LoadFlightSchedule();
    }
}
