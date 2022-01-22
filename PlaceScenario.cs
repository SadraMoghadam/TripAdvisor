using System;
using System.Collections.Generic;
using TripAdvisor.Restaurant;

namespace TripAdvisor
{
    public class PlaceScenario
    {
        public static void placeScenarios()
        {
            PlaceInfo hotelPlaceInfo = new PlaceInfo("hotel plazza", "Paris", "Paris there", "41°24'12.2'N 2°10'26.5'E.", "one of the best paris hotels", "02122334455", 4.5, 10000);
            PlaceInfo restaurantPlaceInfo = new PlaceInfo("plazza restaurant", "Paris", "Paris there", "41°24'12.2'N 2°10'26.5'E.", "one of the best paris restaurants", "02122334466", 4.8, 50);
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("1.Hotel 2.Restaurant 3.exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        HotelScenarios();
                        break;
                    case 2:
                        RestaurantScenarios();
                        break;
                    case 3:
                        break;
                }
                if (menu == 3)
                    break;
            }
        }

        public static void HotelScenarios()
        {
            PlaceInfo hotelPlaceInfo = new PlaceInfo("hotel plazza", "Paris", "Paris there", "41°24'12.2'N 2°10'26.5'E.", "one of the best paris hotels", "02122334455", 4.5, 10000);
            List<TravelerType> travelerTypes= new List<TravelerType>();
            travelerTypes.Add(TravelerType.Couples);
            travelerTypes.Add(TravelerType.Families);
            List<Comment> comments = new List<Comment>();
            Comment comment = new Comment("ali", DateTime.Now, "paris", "its awsome", 4.5);
            comments.Add(comment);
            List<Review> reviews = new List<Review>();
            Review review = new Review(null, null, travelerTypes, comments, "English");
            reviews.Add(review);
            List<string> temp = new List<string>();
            temp.Add("a");
            temp.Add("b");
            List<string> expectations = temp;
            List<string> style = temp;
            List<string> amenities = temp;
            List<string> propertyTypes = temp;
            List<string> roomFeatures = temp;
            List<int> similarHotels = new List<int>();
            similarHotels.Add(3);
            similarHotels.Add(5);
            Place place = new Place(1, hotelPlaceInfo, reviews, expectations);
            place.redirectToPage();
            Hotel hotel = new Hotel(style, amenities, propertyTypes, roomFeatures, similarHotels);
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("1.ShowHotel 2.ReserveHotel 3.HotelSearch 4.Exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        hotel.getHotelRatings();
                        hotel.getSimilarHotels();
                        hotel.showHotel();
                        review.getComments();
                        review.showReview();
                        break;
                    case 2:
                        hotel.connectToBooking();
                        break;
                    case 3:
                        Console.WriteLine("fill hotel search fields: ");
                        Console.WriteLine("enter check-in date: ");
                        Console.Write("Enter a month: ");
                        int monthIn = int.Parse(Console.ReadLine());
                        Console.Write("Enter a day: ");
                        int dayIn = int.Parse(Console.ReadLine());
                        Console.Write("Enter a year: ");
                        int yearIn = int.Parse(Console.ReadLine());
                        DateTime checkIn = new DateTime(yearIn, monthIn, dayIn);
                        Console.WriteLine("enter check-out date: ");
                        Console.Write("Enter a month: ");
                        int monthOut = int.Parse(Console.ReadLine());
                        Console.Write("Enter a day: ");
                        int dayOut = int.Parse(Console.ReadLine());
                        Console.Write("Enter a year: ");
                        int yearOut = int.Parse(Console.ReadLine());
                        DateTime checkOut = new DateTime(yearOut, monthOut, dayOut);
                        Console.Write("number of needed rooms: ");
                        int roomNum = int.Parse(Console.ReadLine());
                        Console.Write("number of adults: ");
                        int adultsNum = int.Parse(Console.ReadLine());
                        Console.Write("number of children: ");
                        int childrensNum = int.Parse(Console.ReadLine());
                        HotelSearchFields hotelSearchFields = new HotelSearchFields(checkIn, checkOut, roomNum, adultsNum, childrensNum);
                        HotelSearch hotelSearch = new HotelSearch();
                        hotelSearch.search(hotelSearchFields);
                        break;
                    case 4:
                        break;
                }
                if (menu == 4)
                    break;
            }
        }

        public static void RestaurantScenarios()
        {
            PlaceInfo restaurantPlaceInfo = new PlaceInfo("plazza restaurant", "Paris", "Paris there", "41°24'12.2'N 2°10'26.5'E.", "one of the best paris restaurants", "02122334466", 4.8, 50);
            List<TravelerType> travelerTypes= new List<TravelerType>();
            travelerTypes.Add(TravelerType.Couples);
            travelerTypes.Add(TravelerType.Families);
            List<Comment> comments = new List<Comment>();
            Comment comment = new Comment("ali", DateTime.Now, "paris", "its awsome", 4.5);
            comments.Add(comment);
            List<Review> reviews = new List<Review>();
            Review review = new Review(null, null, travelerTypes, comments, "English");
            reviews.Add(review);
            Place place = new Place(1, restaurantPlaceInfo, reviews, null);
            place.redirectToPage();
            Restaurant.Restaurant restaurant = new Restaurant.Restaurant(null, null, null, null, 100);
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("1.ShowRestaurant 2.ReserveTable 3.RestaurantSearch 4.Exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        // Console.WriteLine(restaurant.PlaceId);
                        restaurant.findSimilarRestaurants();
                        restaurant.showRestaurant();
                        review.getComments();
                        review.showReview();
                        break;
                    case 2:
                        restaurant.reserveTable(1, DateTime.Now);
                        break;
                    case 3:
                        Console.WriteLine("fill restaurant search fields: ");
                        Console.WriteLine("enter check-in date: ");
                        Console.Write("Enter restaurant name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter restaurant city: ");
                        string city = Console.ReadLine();
                        Console.Write("Enter restaurant nation: ");
                        string nation = Console.ReadLine();
                        RestaurantSearchFields restaurantSearchFields = new RestaurantSearchFields(name, city, nation);
                        RestaurantSearch restaurantSearch = new RestaurantSearch();
                        restaurantSearch.search(restaurantSearchFields);
                        break;
                    case 4:
                        break;
                }
                if (menu == 4)
                    break;
            }
        }
    }
}