using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement
{
    class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int ID { get; set; }
        public string Password { get; set; }

        public static int id = 1;

        public User(string n, string s, string e, string u)
        {
            
            this.Name = n;
            this.SurName = s;
            this.Username = u;
            this.Email = e;
            this.ID = id++;


        }

    }
}