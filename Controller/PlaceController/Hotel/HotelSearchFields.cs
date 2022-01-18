using System;
using System.Collections.Generic;

namespace TripAdvisor
{
    public class HotelSearchFields
    {
        private DateTime checkIn;
        private DateTime checkOut;
        private int roomNum;
        private int adultsNum;
        private int childrensNum;

        public DateTime CheckIn => checkIn;

        public DateTime CheckOut => checkOut;

        public int RoomNum => roomNum;

        public int AdultsNum => adultsNum;

        public int ChildrensNum => childrensNum;

        public HotelSearchFields(DateTime checkIn, DateTime checkOut, int roomNum, int adultsNum, int childrensNum)
        {
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.roomNum = roomNum;
            this.adultsNum = adultsNum;
            this.childrensNum = childrensNum;
        }
        
        public void setFields(DateTime checkIn, DateTime checkOut, int roomNum, int adultsNum, int childrensNum)
        {
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.roomNum = roomNum;
            this.adultsNum = adultsNum;
            this.childrensNum = childrensNum;
        }
    }
}