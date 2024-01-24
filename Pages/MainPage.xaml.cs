using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_App.Helper;
using Xamarin.Forms;

namespace Travel_App
{
    public partial class MainPage : ContentPage
    {
        //addTour addtour = new addTour();
        List<Trip> currentTrips = new List<Trip>();

        public MainPage()
        {
            InitializeComponent();
            currentTrips= TripHelper.m_tps;

            foreach (var i in currentTrips)
            {
                lvTrips.ItemsSource = currentTrips;
            }
        }

        private void imgTap_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new addTour());

        }

        private void lvTrips_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
