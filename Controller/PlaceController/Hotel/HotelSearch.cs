using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class HotelSearch
    {
        private HotelSearchFields hotelSearchFields;

        public HotelSearchFields HotelSearchFields => hotelSearchFields;

        public HotelSearch(HotelSearchFields hotelSearchFields)
        {
            this.hotelSearchFields = hotelSearchFields;
        }

        public List<Hotel> search()
        {
            Console.WriteLine("return searched hotels");
            return null;
        }
    }
}