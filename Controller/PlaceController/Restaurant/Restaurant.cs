using System;
using System.Collections.Generic;
using System.Linq;

namespace TripAdvisor.Restaurant
{
    public class Restaurant: Place
    {
        private RestaurantDetails restaurantDetails;
        private RestaurantRaitings restaurantRaitings;
        private Dictionary<string, float> menu;
        private List<Restaurant> similarRestaurants;
        private int numOfTables;
        private int[] reservedTables;
        
        public RestaurantDetails RestaurantDetails => restaurantDetails;

        public RestaurantRaitings RestaurantRaitings => restaurantRaitings;

        public List<Restaurant> SimilarRestaurants => similarRestaurants;

        public Restaurant(RestaurantDetails restaurantDetails, RestaurantRaitings restaurantRaitings, Dictionary<string, float> menu, List<Restaurant> similarRestaurants, int numOfTables)
        : base(null, null, null)
        {
            this.restaurantDetails = restaurantDetails;
            this.restaurantRaitings = restaurantRaitings;
            this.menu = menu;
            this.similarRestaurants = similarRestaurants;
            this.numOfTables = numOfTables;
            reservedTables = new int[numOfTables];
        }

        public List<Restaurant> findSimilarRestaurants()
        {
            Console.WriteLine("finding similar restaurants");
            return null;
        }

        public string reserveTable(int tableNum, DateTime time)
        {
            Console.WriteLine("reserving table");
            if (reservedTables.Contains(tableNum))
                return "you can't reserve table number " + tableNum.ToString();
            return "table number " + tableNum.ToString() + " is reserved";
        }

        public void showRestaurant()
        {
            Console.WriteLine("showing restaurant");
        }
    }
}