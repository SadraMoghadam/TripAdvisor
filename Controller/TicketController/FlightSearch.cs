using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class FlightSearch
    {
        private OneWaySearchFields flightSearchFields;

        public OneWaySearchFields FlightSearchFields => flightSearchFields;

        public FlightSearch(OneWaySearchFields flightSearchFields)
        {
            this.flightSearchFields = flightSearchFields;
        }

        public List<Flight> search(OneWaySearchFields f)
        {
            Console.WriteLine("return searched flights");
            return null;
        }
    }
}