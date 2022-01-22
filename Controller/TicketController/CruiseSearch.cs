using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class CruiseSearch
    {
        private CruiseSearchFields cruiseSearchFields;

        public CruiseSearchFields cruiseSearchFields => cruiseSearchFields;

        public CruiseSearch(CruiselSearchFields cruiseSearchFields)
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