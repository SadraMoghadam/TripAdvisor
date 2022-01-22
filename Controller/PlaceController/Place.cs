using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class Place
    {
        #region Singleton Pattern

        private static Place instance;

        public static Place Instance
        {
            get
            {
                return instance;
            }
        }

        #endregion

        private int placeId;
        private PlaceInfo placeInfo;
        private List<Review> reviews;
        private List<string> expectations;

        public int PlaceId => placeId;
        
        public PlaceInfo PlaceInfo => placeInfo;

        public List<Review> Reviews => reviews;

        public List<string> Expectations => expectations;

        //public string getPlaceInfo { return thisplaceInfo; }
        //public string getReview { return review; }
        //public string getExpectations { return expectations; }
        public Place(int placeId, PlaceInfo placeInfo, List<Review> reviews, List<string> expectations)
        {
            // Console.WriteLine("---------------we are in Place---------------");
            this.placeId = placeId;
            this.placeInfo = placeInfo;
            this.reviews = reviews;
            this.expectations = expectations;
        }

        public void redirectToPage()
        {
            instance = new Place(placeId, placeInfo, reviews, expectations);
            Console.WriteLine("redirecting to page ...");
        }
    }
}
