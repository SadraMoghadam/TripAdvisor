using System;
using System.Collections.Generic;

namespace TripAdvisor.Controller.UserController
{
    public interface IPhotosResponsibility
    {
        public int picId { get; set; }
        public string picture { get; set; }
        
        public void addPhoto(int userId, string picture, string city="", string description="")
        {
            Console.WriteLine("added profile picture");
        }
        
        public void updatePhoto(int userId, string picture, int picId=1, string city="", string description="")
        {
            Console.WriteLine("updated profile picture");
        }
        
        public bool deletePhoto(int userId)
        {
            Console.WriteLine("deleted profile picture");
            return true;
        }

        public void showPhoto(int userId)
        {
            Console.WriteLine("showing user photo");
        }
    }
}