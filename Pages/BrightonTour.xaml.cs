using Java.Lang;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;


namespace Travel_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrightonTour : ContentPage
    {
        Pin pin = new Pin
        {
            Label = "Sheffield train station",
            Address = "Sheaf St, Sheffield City Centre, Sheffield S1 2BP",
            Type = PinType.Place,
            Position = new Position(53.37831, -1.46285)
        };
        Pin pin1 = new Pin
        {
            Label = "Compton road",
            Address = "Brighton, East Sussex, BN1 5AN",
            Type = PinType.Place,
            Position = new Position(50.839970172677454, -0.15402763174541667)
        };
        Pin pin2 = new Pin
        {
            Label = "The Lanes",
            Address = "Brighton, East Sussex",
            Type = PinType.Place,
            Position = new Position(50.82258, -0.14178)
        };
        Pin pin3 = new Pin
        {
            Label = "Pavilion",
            Address = "Brighton, Easst Sussex, BN1 4GU",
            Type = PinType.Place,
            Position = new Position(50.82894, -0.13535)
        };
        Pin pin4 = new Pin
        {
            Label = "Churchill Square shopping centre",
            Address = "Brighton, Easst Sussex, BN1 2RG",
            Type = PinType.Place,
            Position = new Position(50.82299, -0.14559)
        };
        Pin pin5 = new Pin
        {
            Label = "Brighton Pier",
            Address = "Brighton, Easst Sussex, BN2 1TW",
            Type = PinType.Place,
            Position = new Position(50.81691, -0.13672)
        };

        private Placemark m_plc = new Placemark
        {
            CountryName = "England",
            AdminArea = "East sussex",
            Thoroughfare = "6 Compton Road",
            Locality = "Sheffield",
            PostalCode = "BN1 5AN"
        };

        public List<string> info = new List<string>()
        {
            "Sheffield train station",
            "Compton road - The house you're staying in",
            "The lanes",
            "Pavilion",
            "Churchill Square",
            "Brighton Pier"
        };
        
        public BrightonTour()
        {
            InitializeComponent();
            lvBrighton.ItemsSource = info;
        }

        protected async override void OnAppearing()
        {
            var position = new Position(52.94959130068399, -1.1429234027777797);
            MapSpan mapSpan = MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(0.444));
            map.MoveToRegion(mapSpan);
            map.Pins.Add(pin);
            map.Pins.Add(pin1);
            map.Pins.Add(pin2);
            map.Pins.Add(pin3);
            map.Pins.Add(pin4);
            map.Pins.Add(pin5);
        }

        private void btnback_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Trips());
        }

        private void imgdoc_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Documents());
        }

        private void lvBrighton_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}