using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement
{
    interface IService 
    {
        public void AddUsers();

        public void DeleteUsers();

        public void CheckIn(User u);

        public void CheckOut();


    }
}