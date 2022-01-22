using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class Flight
    {
        private List<FlightInfo> flights;

        public Flight(List<FlightInfo> flights)
        {
            this.flights = flights;
        }

        public void showFlights()
        {
            Console.WriteLine("showing list of flights");
            return null;
        }
    }
}