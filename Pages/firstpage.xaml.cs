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
    public partial class firstpage : ContentPage
    {
        public firstpage()
        {
            InitializeComponent();
        }

        private void btnStart_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}