using System;

namespace TripAdvisor.Controller.UserController
{
    public class TravelPhotos: IPhotosResponsibility
    {
        public int picId { get; set; }
        public string picture { get; set; }
        public string city { get; set; }
        public string description { get; set; }
        
        public void addPhoto(int userId, string picture, string city, string description)
        {
            this.picId = 1;
            this.picture = picture;
            this.city = city;
            this.description = description;
            Console.WriteLine("added a travel picture");
        }
        
        public void updatePhoto(int userId, string picture, int picId, string city, string description)
        {
            this.picture = picture;
            this.city = city;
            this.description = description;
            Console.WriteLine("updated the travel picture");
        }
        
        public bool deletePhoto(int userId, int picId)
        {
            this.picture = "";
            this.city = "";
            this.description = "";
            Console.WriteLine("deleted the travel picture");
            return true;
        }

        public void showPhoto(int userId)
        {
            // Console.WriteLine("showing user travel photo: " + this.picture + " in " + city + "with description " + description);
            Console.WriteLine("showing user travel photos");
        }
    }
}