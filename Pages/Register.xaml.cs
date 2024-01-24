using Android.OS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {

        string recipient = "07429780888";
        string messageText = "Brighton tour added!!!" + " Tour number:1234";
             

        public Register()
        {
            InitializeComponent();
        }

        async Task SendSms(string m_recipient, string m_messageText)
        {
            try
            {   var message = new SmsMessage(messageText, new[] { recipient });
                await Sms.ComposeAsync(message);
            }
            catch(FeatureNotEnabledException ex)
            {

            }
            catch(Exception ex)
            {

            }
        }
        private async void btnReg_Clicked(object sender, EventArgs e)
        {
            await SendSms(recipient, messageText);
            Application.Current.MainPage = new NavigationPage(new addTour());
        }

        private void btnback_Clicked(object sender, EventArgs e)
        {

        }

        private void btndoc_Clicked(object sender, EventArgs e)
        {

        }
    }
}