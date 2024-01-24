using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_App.Pages
{
    internal class UserDetails
    {
        public int UserId;
        public string email;
        public string First_Name;
        public string Last_Name;
        public int age;
        public int tourId;
        public int PhoneNumber;

        public UserDetails(int UserId, string email, int tourNum, string First_Name, string Last_Name, int age, int tourId, int PhoneNumber)
        {
            this.UserId = UserId;
            this.email = email;
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.age = age;
            this.tourId = tourId;
            this.PhoneNumber = PhoneNumber;
        }
    }
}
