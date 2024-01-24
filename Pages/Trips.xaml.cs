using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Trips : ContentPage
    {
        public Trips()
        {
            InitializeComponent();
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            lbltest.IsVisible = false;
            frswipe.IsVisible = false;
        }

        private void lbltap_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new BrightonTour());
        }

        private void btnadd_Clicked(object sender, EventArgs e)
        {

        }
    }
}