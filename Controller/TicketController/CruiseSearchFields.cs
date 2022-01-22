using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class CruiseSearchFields
    {

        private List<Country> country;
        private List<DepartureMonth> departureMonth;


        public CruiseSearchFields(List<Country> country, List<DepartureMonth> departureMonth)
        {
            this.country = country;
            this.departureMonth = departureMonth;
        }
        

    }
}