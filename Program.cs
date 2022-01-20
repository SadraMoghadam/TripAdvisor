using System;
using System.Collections.Generic;
using System.Linq;

namespace TripAdvisor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            PlaceInfo pi = new PlaceInfo("a", "b", "c", "d", "e", "f", 1, 2);
            List<TravelerType> travelerTypes= new List<TravelerType>();
            travelerTypes.Add(TravelerType.Couples);
            travelerTypes.Add(TravelerType.Families);
            List<Comment> comments = new List<Comment>();
            Comment comment = new Comment("ali", DateTime.Now, "paris", "its awsome", 4.5);
            comments.Add(comment);
            List<Review> reviews = new List<Review>();
            Review review = new Review(null, null, travelerTypes, comments, "English");
            reviews.Add(review);
            Place p = new Place(1, pi, reviews, null);

            
            Console.WriteLine(pi.Name);
            Console.WriteLine(p.PlaceInfo.Name);
            
            
            Console.WriteLine(p.Reviews.First().getComments());
        }
    }
}
