using System;
using System.Collections.Generic;

namespace TripAdvisor.Restaurant
{
    public class RestaurantSearch: ISearch<Restaurant, RestaurantSearchFields>
    {
        private RestaurantSearchFields restaurantSearchFields;
        public List<Restaurant> search(RestaurantSearchFields Fields)
        {
            Console.WriteLine("searching for restaurants");
            return null;
        }
    }
}