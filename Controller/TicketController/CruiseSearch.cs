using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class CruiseSearch
    {
        private CruiseSearchFields cruiseSearchFields;

        public CruiseSearchFields CruisesearchFields => cruiseSearchFields;

        public CruiseSearch(CruiseSearchFields cruiseSearchFields)
        {
            this.cruiseSearchFields = cruiseSearchFields;
        }

        public List<Cruise> search(CruiseSearchFields cruiseSearchFields)
        {
            Console.WriteLine("return searched cruises");
            return null;
        }
    }
    
}