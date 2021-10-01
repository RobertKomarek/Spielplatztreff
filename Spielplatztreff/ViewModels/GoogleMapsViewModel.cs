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
            Locations = new ObservableCollection<Location>
            {
                new Location
                {
                    Address = "Darmstädter Str. 4, Rodgau, Nieder-Roden",
                    Label = "Christoph Raub",
                    Position = new Position(49.998952330538785, 8.858705579474542)
                },

                new Location
                {
                    Address = "Wormser Str. 18, Rodgau, Nieder-Roden",
                    Label = "Robert Komarek",
                    Position = new Position(49.99902278445617, 8.856807771457397)
                }
            };
        }
    }
}
