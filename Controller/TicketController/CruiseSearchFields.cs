using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class ClightSearchFields
    {

        private List<Country> country;
        private List<DepartureMonth> departureMonth;


        public ClightSearchFields(List<Country> country, List<DepartureMonth> departureMonth)
        {
            this.country = country;
            this.departureMonth = departureMonth;
        }

    }
}