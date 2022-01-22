using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class Travelers
    {

        private List<TravelersType> travelersType;
        private int numTravelers;


        public Travelers(List<TravelerType> travelerType, int numTravelers)
        {
            this.travelersType = travelersType;
            this.numTravelers = numTravelers;
        }

    }
}
