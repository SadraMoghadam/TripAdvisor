using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class HotelSearch: ISearch<Hotel, HotelSearchFields>
    {
        private HotelSearchFields hotelSearchFields;

        public HotelSearchFields HotelSearchFields => hotelSearchFields;

        // public HotelSearch(HotelSearchFields hotelSearchFields)
        // {
        //     this.hotelSearchFields = hotelSearchFields;
        // }

        public List<Hotel> search(HotelSearchFields Fields)
        {
            Console.WriteLine("return searched hotels");
            return null;
        }
    }
}