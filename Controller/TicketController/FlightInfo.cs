using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class FlightInfo
    {
        private float price;
        private List<Airline> airline;
        private string fromCity;
        private string destination;

        public float Price => price;

        public List<Airline> AirLine => airline;

        public string FromCity => fromCity;

        public string Destination => destination;


        public CruiseInfo(float price, List<Airline> airline, string fromCity, string destination)
        {
            this.price = price;
            this.airline = airline;
            this.fromCity = fromCity;
            this.destination = destination;
        }


        public void showFlightInfo()
        {
            Console.WriteLine("showing flightInfo");
        }

    }
}