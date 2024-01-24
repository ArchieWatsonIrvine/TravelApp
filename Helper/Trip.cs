using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Travel_App.Helper
{
    public class Trip {
        public string Title;
        public string Description;
        public int ID;

        public Trip(string title, string description, int Id)
        {
            Title = title;
            Description = description;
            ID = Id;
        }
        
    }
}