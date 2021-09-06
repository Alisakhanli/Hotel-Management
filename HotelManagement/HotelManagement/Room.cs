using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement
{
    class Room
    {
        public int RoomNumber { get; set; }
        public string Info { get; set; }
        public User Usr { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        

        public Room(int r, string i)
        {
            RoomNumber = r;
            Info = i;
        }
        public void RoomInfo()
        {
            Console.WriteLine($"Room number: {RoomNumber}\nInfo: {Info}  ");
        }
    }
}
