using Android.Widget;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Documents : ContentPage
    {
        Image newImage;
        int imageId=0;
        Dictionary<int, Image> imagesList = new Dictionary<int, Image> { };


        string PhotoPath;

        public Documents()
        {
            InitializeComponent();
        }

        private void btnback_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new BrightonTour());
        }

        async Task TakePhotoAsync()
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                await LoadPhotoAsync(photo);
                imgphoto.Source = ImageSource.FromFile(PhotoPath);
                Console.WriteLine($"CapturePhotoAsync COMPLETED: {PhotoPath}");
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature is not supported on the device
            }
            catch (PermissionException pEx)
            {
                // Permissions not granted
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }

        async Task LoadPhotoAsync(FileResult photo)
        {
            // canceled
            if (photo == null)
            {
                PhotoPath = null;
                return;
            }
            // save the file into local storage
            var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            using (var stream = await photo.OpenReadAsync())
            using (var newStream = File.OpenWrite(newFile))
            await stream.CopyToAsync(newStream);


            PhotoPath = newFile;
        }

        private async void btnphoto_Clicked(object sender, EventArgs e)
        {
            
        }

        public void CaptureImage(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void imgCam_Tapped(object sender, EventArgs e)
        {
            //hide this button and create a new one when you have taken a photo
            await TakePhotoAsync();
            if (imgphoto != null)
            {
                camBtn.IsVisible = false;
                btnAdd.IsVisible = true;
                btnDelete.IsVisible = true;
                imagesList.Add(imageId,imgphoto);
            }
            else
            {
                camBtn.IsVisible = true;
                btnAdd.IsVisible = false;
                btnDelete.IsVisible = false;
            }
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            //Create new image and add under
            imageId++;
            await TakePhotoAsync();
            imagesList.Add(imageId, imgphoto);
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            //Delete image
            
        }

        private async void btnRetake_Clicked(object sender, EventArgs e)
        {
            await TakePhotoAsync();
        }
    }
}