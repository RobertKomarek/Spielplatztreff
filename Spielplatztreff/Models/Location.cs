using System;
using Xamarin.Forms.Maps;

namespace Spielplatztreff.Models
{
    public class Location
    {
        public Position Position { get; set; }
        public string Label { get; set; }
        public string Address { get; set; }
        public Type Type { get; set; }

        public Location()
        {
        }
    }
}
