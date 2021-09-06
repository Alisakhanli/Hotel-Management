using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement
{
    class Hotel : IService
    {
        public List<User> Users { get; set; }
        public List<Room> Rooms { get; set; }
        public List<string> History { get; private set; }

        public DateTime dt = DateTime.Now;


        public Hotel(List<Room> r)
        {
            Rooms = r;
            Users = new List<User>(0);
        }

        public void Info()
        {
            foreach (var item in Rooms)
            {
                item.RoomInfo();
                Console.WriteLine();
                Console.Write("Person who stays in this room;  ");
                if (item.Usr != null)
                    Console.WriteLine(item.Usr.Username);
                Console.WriteLine("\n\n");


            }
        }

        public void AddUsers()
        {
            Console.Write("Enter your name:  ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname:  ");
            string surname = Console.ReadLine();
            Console.Write("Enter your Email:  ");
            string email = Console.ReadLine();
            Console.Write("Enter your Username:  ");
        a:
            string username = Console.ReadLine();
            if (Users.Find(u => u.Username == username) == null)
            {
                Users.Add(new User(name, surname, email, username));

            }
            else
            {
                Console.Write("This user already exists. Enter another user");
                goto a;
            }
        }


        public void DeleteUsers()
        {

            Console.Write("Enter ID: ");
            a:
            int ID = Convert.ToInt32(Console.ReadLine());
            var u = Users.Find(u => ID == u.ID);
            if (u != null)
            {
                Users.Remove(u);
            }
            else
            {
                Console.Write("This ID does not exist. Please enter another ID:  ");
                goto a;
            }
        }


        public void CheckIn(User u)
        {
            Console.Write("Enter last date: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime LastDate = new DateTime(year, month, day);
            var room = Rooms.FindAll(r => r.LastDate < dt);
            foreach (var item in room)
            {
                item.RoomInfo();
                Console.WriteLine();

            }
            Console.Write("Enter room number: ");
            int roomnumber = Convert.ToInt32(Console.ReadLine());
            var r = room.Find(r => r.RoomNumber == roomnumber);
            r.FirstDate = dt;
            r.LastDate = LastDate;
            r.Usr = u;
        }
            
            public void CheckOut()
            {
                var room = Rooms.FindAll(r => r.LastDate < dt && r.LastDate.Year > 1000 && r.Usr != null);
                for (int i = 0; i < room.Count; i++)
                {
                History.Add(room[i].Usr.Name + "stayed in room number" + room[i].RoomNumber + "\nFrom" + room[i].FirstDate + "\nTo" + room[i].LastDate);
                    Users.Remove(room[i].Usr);
                    room[i].Usr = null;
                }
            }
        }
    }

            

        

        
    
    

