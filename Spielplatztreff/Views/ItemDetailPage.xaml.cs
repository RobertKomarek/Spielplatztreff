using System.ComponentModel;
using Xamarin.Forms;
using Spielplatztreff.ViewModels;

namespace Spielplatztreff.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
