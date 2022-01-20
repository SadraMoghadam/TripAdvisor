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

        public WriteReview(int reviewId, string title, string placeName, int star, string city, string description)
        {
            this.reviewId = reviewId;
            this.title = title;
            this.placeName = placeName;
            this.star = star;
            this.city = city;
            this.description = description;
        }

        public bool submitReview(string title, string description, int star, string placeName, string city)
        {
            Console.WriteLine("review is submitted");
            return true;
        }
    }
}