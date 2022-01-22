using System;

namespace TripAdvisor.Controller.UserController
{
    public class Trip
    {
        private int tripId;
        private string title;
        private string description;
        private string location;


        public void addTrip(int userId, string title, string description, string location)
        {
            Console.WriteLine("added a trip with title " + title + " description " + description + " in the " + location + " location");
        }
        
        public void editTrip(int userId, int tripId, string title, string description, string location)
        {
            Console.WriteLine("edited a trip with title " + title + " description " + description + " in the " + location + " location");
        }

        public void showTrips(int userId)
        {
            Console.WriteLine("showing trips in the user profile");
        }
    }
}