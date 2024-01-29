using System;
using System.Collections.Generic;
using Travel_App.Helper;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Icu.Text.CaseMap;
using static Android.Util.EventLogTags;

namespace Travel_App
{
    public partial class App : Application
    {
        internal static IEnumerable<object> tp;

        public App()
        {
            InitializeComponent();

            MainPage = new Documents();
        }

        protected override void OnStart()
        {

            //generate list
            Trip tp = new Trip("", "", 0)
            {
                Title = "Brighton",
                Description = "Brighton testing description",
                ID = 1
            };
            TripHelper.addTrip(tp);
        }

        //Init list of tour ids

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
