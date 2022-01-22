using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class Airline
    {
        private string airlineName;
        private string fromHour;
        private string DesHour;
        private string airportName;

        public string AirlineName => airlineName;

        public string FromHour => fromHour;

        public string DesHour => desHour;

        public string AirportName => airportName;


        public Airline(string airlineName, string fromHour, string desHour, string airportName)
        {
            this.airlineName = airlineName;
            this.fromHour = fromHour;
            this.desHour = desHour;
            this.airportName = airportName;
        }

        public void showAirline()
        {
            Console.WriteLine("It is an airline");
            return null;
        }
    }
}