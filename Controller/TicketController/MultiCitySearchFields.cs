using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class MultiCitySearchFields : OneWaySearchFields
    {

        private int id;

        private int Id => id;

        public MultiCitySearchFields(int id, string fromCity, string destination, DateTime depart, Travelers traveler) : 
            base(fromCity, destination, depart, traveler)
        {
            this.id = id;
        }
        
      /*  public void setFieldsstring(string fromCity, string destination, DateTime depart, Travelers traveler)
        {
            this.fromCity = fromCity;
            this.destination = destination;
            this.depart = depart;
            this.traveler = traveler;
        }*/

         public MultiCitySearchFields addAnotherFlight()
        {
            Console.WriteLine("add another flight search field");
            return null;
        }

         public MultiCitySearchFields deleteAnotherFlight()
        {
            Console.WriteLine("delete another flight search field");
            return null;
        }
    }
}