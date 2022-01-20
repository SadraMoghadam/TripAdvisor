using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class FlightSearch
    {
        private FlightSearchFields flightSearchFields;

        public FlightSearchFields FlightSearchFields => flightSearchFields;

        public FlightSearch(FlightlSearchFields flightSearchFields)
        {
            this.flightSearchFields = flightSearchFields;
        }

        public List<Flight> search()
        {
            Console.WriteLine("return searched flights");
            return null;
        }
    }
}