using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Maps;

namespace Spielplatztreff.Views
{
    public partial class GoogleMapsPage : ContentPage
    {
        public GoogleMapsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MyLocation();
        }

        private async void MyLocation()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });
                }

                map.MoveToRegion(new MapSpan (map.VisibleRegion.Center, location.Latitude, location.Longitude));
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Info", "Eigener Standort konnte nicht ermittelt werden. Bitte prüfen/aktivieren Sie Ihre GPS-Verbindung!", "OK");
            }
        }
    }
}
