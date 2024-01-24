using Java.Util;
using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Travel_App.Helper;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addTour : ContentPage
    {
        List<Trip> _list = new List<Trip>();
   
        public addTour()
        {
            InitializeComponent();
            foreach (var i in App.tp)
            {
                _list.Add((Trip)i);
            }
        }

        private void btnSub_Clicked(object sender, EventArgs e, tripLists ListName)
        {
            
            string num =  entNum.Text;
            string email = entEmail.Text.ToLower();
            if (_list.ToString().Contains(email) && _list.ToString().Contains(num))
            {
                Application.Current.MainPage = new NavigationPage(new Trips());

                var notificaion = new NotificationRequest
                {
                    Description = _list[2].ToString(),
                    Title = _list[1].ToString(),
                    NotificationId = Convert.ToInt32(_list[3]),
                };

                LocalNotificationCenter.Current.Show(notificaion);
            }
            else
            {
                lblErr.IsVisible = true;
            }
        }

        private void btnadd_Clicked(object sender, EventArgs e)
        {
            TripHelper.addTrip((Trip)App.tp);
        }


        private void tapreg_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Register());
        }
    }
}