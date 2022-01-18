using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class Place
    {
        private PlaceInfo placeInfo;
        private List<Review> reviews;
        private List<string> expectations;

        public PlaceInfo PlaceInfo => placeInfo;

        public List<Review> Reviews => reviews;

        public List<string> Expectations => expectations;

        //public string getPlaceInfo { return thisplaceInfo; }
        //public string getReview { return review; }
        //public string getExpectations { return expectations; }
        public Place(PlaceInfo placeInfo, List<Review> reviews, List<string> expectations)
        {
            Console.WriteLine("---------------we are in Place---------------");
            this.placeInfo = placeInfo;
            this.reviews = reviews;
            this.expectations = expectations;
        }
    }
}
