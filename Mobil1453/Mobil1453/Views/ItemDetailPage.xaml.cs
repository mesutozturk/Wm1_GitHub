using Mobil1453.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Mobil1453.Views
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