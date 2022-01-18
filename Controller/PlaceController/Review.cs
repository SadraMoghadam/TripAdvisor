using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    class Review
    {
        private List<Rating> travelerRating;
        private List<TimeOfYear> timeOfYear;
        private List<TravelerType> travelerType;
        private List<Comment> comments;
        private string language;
        // public List<Rating> getTravelerRating { return travelerRating; }
        // public List<TimeOfYear> getTimeOfYear { return timeOfYear; }
        // public List<TravelerType> getTravelerType { return travelerType; }
        // public List<Comment> getComments { return comments; }
        // public string getLanguage { return language; }
        public Review(List<Rating> travelerRating, List<TimeOfYear> timeOfYear, List<TravelerType> travelerType, List<Comment> comments, string language)
        {
            this.travelerRating = travelerRating;
            this.timeOfYear = timeOfYear;
            this.travelerType = travelerType;
            this.comments = comments;
            this.language = language;
        }

        public List<Comment> getComments()
        {
            Console.WriteLine("getting comments from database");
            return null;
        }
        
        public void showReview(List<Rating> travelerRating, List<TimeOfYear> timeOfYear, List<TravelerType> travelerType, 
                            List<Comment> comments, string language)
        {
            // for(int i = 0; i < travelerRating.Count; i++)
            //     System.Console.WriteLine();
            Console.WriteLine("showing review");
        }

        public void writeReview()
        {
            Console.WriteLine("connect to WriteReview class to write review");
        }
    }
}
