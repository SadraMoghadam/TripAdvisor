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

        public void showFlights(List<FlightInfo> flightInfos)
        {
            for (int i = 0; i < flightInfos.Count; i++)
            {
                Console.WriteLine(flightInfos);
            }
        }
    }
}