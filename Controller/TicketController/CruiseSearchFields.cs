using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class CruiseSearchFields
    {

        private Country country;
        private DepartureMonth departureMonth;


        public CruiseSearchFields(Country country, DepartureMonth departureMonth)
        {
            this.country = country;
            this.departureMonth = departureMonth;
        }
        

    }
}