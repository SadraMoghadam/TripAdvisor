using System;

namespace TripAdvisor.Controller.UserController
{
    public class WriteReview
    {
        private int reviewId;
        private string title;
        private string placeName;
        private int star;
        private string city;
        private string description;

        public bool submitReview(int reviewId, string title, string description, int star, string placeName, string city)
        {
            Console.WriteLine("review is submitted");
            return true;
        }
    }
}