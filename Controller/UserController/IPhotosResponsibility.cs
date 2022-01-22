using System;
using System.Collections.Generic;

namespace TripAdvisor.Controller.UserController
{
    public interface IPhotosResponsibility
    {
        public int picId { get; set; }
        public string picture { get; set; }

        public void addPhoto(int userId, string picture, string city = "", string description = "");

        public void updatePhoto(int userId, string picture, int picId = 1, string city = "", string description = "");

        public bool deletePhoto(int userId, int picId);

        public void showPhoto(int userId);
    }
}