using System;
using System.Collections.ObjectModel;
using Spielplatztreff.Models;
using Xamarin.Forms.Maps;

namespace Spielplatztreff.ViewModels
{
    public class GoogleMapsViewModel : BaseViewModel
    {
        public ObservableCollection<Location> Locations { get; set; }

        public GoogleMapsViewModel()
        {

            Locations = new ObservableCollection<Location>();
        }
    }
}
