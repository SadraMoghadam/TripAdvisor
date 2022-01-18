using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class Comment
    {
        private int id;
        private string name;
        private DateTime date;
        private string location;
        private string text;
        private double stars;
        private List<Comment> replies;

        public int Id => id;
        
        public string Name => name;

        public DateTime Date => date;

        public string Location => location;

        public string Text => text;

        public double Stars => stars;

        public Comment(string name, DateTime date, string location, string text, double stars)
        {
            this.name = name;
            this.date = date;
            this.location = location;
            this.text = text;
            this.stars = stars;
        }

        public void showComment()
        {
            Console.WriteLine("showing comment ");
        }

        public List<Comment> getReplies()
        {
            Console.WriteLine("getting replies from database");
            return null;
        }
        
        public void showReplies(List<Comment> replies)
        {
            Console.WriteLine("showing replies");
        }
    }
}