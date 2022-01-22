using System;
using System.Collections.Generic;

namespace TripAdvisor.Controller.UserController
{
    public class Photos: IPhotosResponsibility
    {
        public int picId { get; set; }
        public string picture { get; set; }

        public void addPhoto(int userId, string picture, string city="", string description="")
        {
            this.picture = picture;
            Console.WriteLine("added a picture");
        }
        
        public void updatePhoto(int userId, string picture, int picId=1, string city="", string description="")
        {
            this.picture = picture;
            Console.WriteLine("updated the picture");
        }
        
        public bool deletePhoto(int userId)
        {
            this.picture = "";
            Console.WriteLine("deleted the picture");
            return true;
        }

        public void showPhoto(int userId)
        {
            // Console.WriteLine("showing user photo: " + this.picture);
            Console.WriteLine("showing user photos");
        }
    }
}