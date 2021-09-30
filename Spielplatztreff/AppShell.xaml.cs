using System;
using System.Collections.Generic;
using Spielplatztreff.ViewModels;
using Spielplatztreff.Views;
using Xamarin.Forms;

namespace Spielplatztreff
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(GoogleMapsPage), typeof(GoogleMapsPage));
        }

    }
}
