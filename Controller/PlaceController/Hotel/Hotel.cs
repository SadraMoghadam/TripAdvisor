using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class Hotel: Place
    {
        private List<string> style;
        private List<string> amenities;
        private List<string> propertyTypes;
        private List<string> roomFeatures;
        private List<Hotel> similarHotels;

        public Hotel(List<string> style, List<string> amenities, List<string> propertyTypes, List<string> roomFeatures, List<Hotel> similarHotels)
        : base(null, null, null)
        {
            this.style = style;
            this.amenities = amenities;
            this.propertyTypes = propertyTypes;
            this.roomFeatures = roomFeatures;
            this.similarHotels = similarHotels;
        }

        public HotelRatings getHotelRatings()
        {
            Console.WriteLine("getting hotel ratings from database");
            return null;
        }

        public void showHotel()
        {
            Console.WriteLine("showing hotel");
        }

        public void connectToBooking()
        {
            Console.WriteLine("connecting to booking sites");
        }
        
        public List<Hotel> getSimilarHotels()
        {
            Console.WriteLine("getting similar hotels");
            return null;
        }
    }
}