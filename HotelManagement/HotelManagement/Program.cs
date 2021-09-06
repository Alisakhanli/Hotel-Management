using System;
using System.Collections.Generic;

namespace HotelManagement
{
    class Program
    {
        static void Main(string[] args)
            
        {
            List<Room> rooms = new List<Room>()
            {
                new Room(1,"4 otaqli"), new Room (2,"2otaqli"), new Room(3,"3 otaqli")
            };
            Hotel ht = new Hotel(rooms);
            byte choose = 255;
            while (true)
            {
                Console.Clear();
                ht.CheckOut();
                Console.WriteLine($"Date: {ht.dt}\n");
                Console.WriteLine("1.Check In");
                Console.WriteLine("2.Show info about rooms");
                Console.WriteLine("3.End work day");
                Console.WriteLine("Choose an option: ");
                choose = Convert.ToByte(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        ht.AddUsers();
                        ht.CheckIn(ht.Users [ht.Users.Count-1]);
                        break;

                    case 2:
                        Console.Clear();
                        ht.Info();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        foreach (var item in ht.History)
                        {
                            Console.WriteLine(item+ "\n\n");

                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        ht.dt = ht.dt.AddDays(1);
                        break;
                    default:
                        break;

                    
                }

            }



        }
    }
}
