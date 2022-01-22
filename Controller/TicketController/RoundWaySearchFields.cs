using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class RoundWaySearchFields : OneWaySearchFields
    {

       // public static FlightSearchFields flightSearchFields;

        private DateTime returnDate;

        public DateTime ReturnDate => returnDate;


        public RoundWaySearchFields(string fromCity, string destination, DateTime depart, DateTime returnDate, Travelers traveler)
        : base(fromCity, destination, depart, traveler)
        {
            this.returnDate = returnDate;
        }
        
       /* public void setFieldsstring(string fromCity, string destination, DateTime depart, DateTime returnDate, Travelers traveler)
        {
            this.fromCity = fromCity;
            this.destination = destination;
            this.depart = depart;
            this.returnDate = returnDate;
            this.traveler = traveler;
        }*/
    }
}