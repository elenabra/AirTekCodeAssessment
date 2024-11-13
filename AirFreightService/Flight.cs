namespace AirFreightService
{
    /// <summary>
    /// Flight data
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// The Id of the flight
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The day of the flight
        /// </summary>
        public int Day { get; set; }
        /// <summary>
        /// The departure airport code
        /// </summary>
        public string Departure { get; set; }   //   YUL - Montreal,  YYZ - Toronto   YYC - Calgary, YVR - Vancouver
        /// <summary>
        /// The destination airport code
        /// </summary>
        public string Destination { get; set; }  //   YUL - Montreal,  YYZ - Toronto   YYC - Calgary, YVR - Vancouver
        /// <summary>
        /// Capacity of boxes for flight
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Actual number of boxes on flight
        /// </summary>
        public int BoxesOnBoard { get; set; }

        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Flight: {Id}, departure: {Departure}, arrival: {Destination}, day: {Day}";
        }
    }
}
