using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    class Place
    {
        private PlaceInfo placeInfo;
        private List<Review> review;
        private List<string> expectations;

        public PlaceInfo PlaceInfo
        {
            get => placeInfo;
            set => placeInfo = value;
        }

        public List<Review> Review
        {
            get => review;
            set => review = value;
        }

        public List<string> Expectations
        {
            get => expectations;
            set => expectations = value;
        }

        //public string getPlaceInfo { return thisplaceInfo; }
        //public string getReview { return review; }
        //public string getExpectations { return expectations; }
        public Place(PlaceInfo placeInfo, List<Review> review, List<string> expectations)
        {
            Console.WriteLine("---------------we are in Place---------------");
            this.placeInfo = placeInfo;
            this.review = review;
            this.expectations = expectations;
        }
    }
}
