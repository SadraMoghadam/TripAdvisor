using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class OneWaySearchFields  
    {

        private string fromCity;
        private string destination;
        private DateTime depart;
        private Travelers traveler;

        public string FromCity => fromCity;

        public DateTime Depart => depart;

        public string Destination => destination;

        public Travelers Traveler => traveler;


        public OneWaySearchFields(string fromCity, string destination, DateTime depart, Travelers traveler)
        {
            this.fromCity = fromCity;
            this.destination = destination;
            this.depart = depart;
            this.traveler = traveler;
        }
        
        public void setFieldsstring(string fromCity, string destination, DateTime depart, Travelers traveler)
        {
            this.fromCity = fromCity;
            this.destination = destination;
            this.depart = depart;
            this.traveler = traveler;
        }
    }
}