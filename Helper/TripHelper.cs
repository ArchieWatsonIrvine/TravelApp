using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Travel_App.Helper
{
    public class TripHelper : ContentPage
    {
        
        public TripHelper()
        {
            
        }

        public static List<Trip> m_tps = new List<Trip>();
        public static void addTrip(Trip tp)
        {
            m_tps.Add(tp);
        }
        public static List<Trip> getTrips(Trip tp)
        {
            m_tps.Add(tp);
            return m_tps;
        }
    }
}